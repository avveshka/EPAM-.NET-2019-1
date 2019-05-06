using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UserSqlList : IUserStorage
    {
        private readonly string connectionString;
        public UserSqlList(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Add(User user)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                command.CommandText = "AddUser";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;

                command.Parameters.AddWithValue("@firstname", user.FirstName);
                command.Parameters.AddWithValue("@lastname", user.LastName);
                command.Parameters.AddWithValue("@birthday", user.BirthDay);
                DataTable tempAwardsTable = new DataTable();
                tempAwardsTable.Columns.Add("idAward", typeof(int));
                foreach (var item in user.AwardList)
                {
                    tempAwardsTable.Rows.Add(item.ID);
                }
                command.Parameters.AddWithValue("@awardIds", tempAwardsTable);

                connection.Open();

                command.ExecuteNonQuery();

                connection.Close();
            }
        }

        public void Remove(User user)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                command.CommandText = "RemoveUser";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;

                command.Parameters.AddWithValue("@id", user.ID);

                connection.Open();

                command.ExecuteNonQuery();

                connection.Close();
            }
        }

        public void DeleteAwardFromUser(Award award)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                command.CommandText = "DeleteAwardsFromUser";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;

                foreach (var item in GetList())
                {
                    if (item.AwardList.Contains(award))
                    {
                        command.Parameters.AddWithValue("@idUser", item.ID);
                        command.Parameters.AddWithValue("@idAward", award.ID);
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }

            }
        }

        public BindingList<User> GetList()
        {
            var temp = new BindingList<User>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                command.CommandText = "select * from Users";
                command.CommandType = CommandType.Text;
                command.Connection = connection;

                connection.Open();

                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var user = new User(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetDateTime(3));
                    temp.Add(user);
                }
                connection.Close();
            }
            temp = GetAwardsForListUser(temp);
            return temp;
        }

        public BindingList<User> GetAwardsForListUser(BindingList<User> temp)
        {
            AwardSqlList awardSqlList = new AwardSqlList(connectionString);
            var fullawardlist = awardSqlList.GetList();
            var i = 0;
            using (var secondconnection = new SqlConnection(connectionString))
            using (var innercommand = new SqlCommand())
            {
                secondconnection.Open();
                foreach (var item in temp)
                {
                    innercommand.CommandText = $"select awardID from UserAward where userID = {item.ID}";
                    innercommand.CommandType = CommandType.Text;
                    innercommand.Connection = secondconnection;
                    //innercommand.Parameters.AddWithValue("userID", item.ID);

                    var secondreader = innercommand.ExecuteReader();

                    while (secondreader.Read())
                    {
                        foreach (var awardItem in fullawardlist)
                        {
                            if(awardItem.ID == secondreader.GetInt32(0))
                            {
                                temp[i].AddAward(awardItem);
                            }
                        }
                    }
                    secondreader.Close();
                    //innercommand.Parameters.RemoveAt(0);
                    i++;
                }
                secondconnection.Close();
            }
            return temp;
        }

        public void AddAward(Award award, int pos)
        {
            throw new NotImplementedException();
        }

        public void EditUser(User user)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                command.CommandText = "EditUser";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;

                command.Parameters.AddWithValue("@id", user.ID);
                command.Parameters.AddWithValue("@firstname", user.FirstName);
                command.Parameters.AddWithValue("@lastname", user.LastName);
                command.Parameters.AddWithValue("@birthday", user.BirthDay);
                DataTable tempAwardsTable = new DataTable();
                tempAwardsTable.Columns.Add("idAward", typeof(int));
                foreach (var item in user.AwardList)
                {
                    tempAwardsTable.Rows.Add(item.ID);
                }
                command.Parameters.AddWithValue("@awardIds", tempAwardsTable);

                connection.Open();

                command.ExecuteNonQuery();

                connection.Close();
            }
        }
    }
}
