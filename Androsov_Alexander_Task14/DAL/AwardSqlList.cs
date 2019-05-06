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
    public class AwardSqlList : IAwardStorage
    {
        private readonly string connectionString;
        public AwardSqlList(string connectionString)
        {   
            this.connectionString = connectionString;
        }

        public void Add(Award award)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                command.CommandText = "AddAward";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;

                command.Parameters.AddWithValue("@title", award.Title);
                command.Parameters.AddWithValue("@description", award.Description);

                connection.Open();

                command.ExecuteNonQuery();

                connection.Close();
            }
        }

        public void Remove(Award award)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                command.CommandText = "RemoveAward";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;

                command.Parameters.AddWithValue("@id", award.ID);

                connection.Open();

                command.ExecuteNonQuery();

                connection.Close();
            }
        }

        public BindingList<Award> GetList()
        {
            var temp = new BindingList<Award>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                command.CommandText = "select * from Awards";
                command.CommandType = CommandType.Text;
                command.Connection = connection;

                connection.Open();

                var reader = command.ExecuteReader();
                while(reader.Read())
                {
                    if (!reader.IsDBNull(2))
                    {
                        var award = new Award(reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
                        temp.Add(award);
                    }
                    else
                    {
                        var award = new Award(reader.GetInt32(0), reader.GetString(1));
                        temp.Add(award);
                    }
                }

                connection.Close();
            }
            return temp;
        }

        public void EditAward(Award award)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                command.CommandText = "EditAward";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;

                command.Parameters.AddWithValue("@id", award.ID);
                command.Parameters.AddWithValue("@title", award.Title);
                command.Parameters.AddWithValue("@description", award.Description);

                connection.Open();

                command.ExecuteNonQuery();

                connection.Close();
            }
        }
    }
}
