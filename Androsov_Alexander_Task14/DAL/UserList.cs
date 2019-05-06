using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UserList : IUserStorage
    {
        public BindingList<User> ListUsers;

        public UserList()
        {
            ListUsers = new BindingList<User>();
        }

        public void Add(User user)
        {
            ListUsers.Add(user);
        }

        public void Remove(User user)
        {
            ListUsers.Remove(user);
        }

        public void DeleteAwardFromUser(Award award)
        {
            for (int i = 0; i < ListUsers.Count; i++)
            {
                if (ListUsers[i].AwardList.Contains(award))
                {
                    ListUsers[i].AwardList.Remove(award);
                    ListUsers[i].UserShowAwardInicialization();
                }
            }
        }

        public BindingList<User> GetList()
        {
            return ListUsers;
        }

        public void AddAward(Award award, int pos)
        {
            ListUsers[pos].AddAward(award);
        }

        public void EditUser(User user)
        {
            for (int i = 0; i < ListUsers.Count; i++)
            {
                if(ListUsers[i].ID == user.ID)
                {
                    ListUsers[i].FirstName = user.FirstName;
                    ListUsers[i].LastName = user.LastName;
                    ListUsers[i].BirthDay = user.BirthDay;
                    ListUsers[i].AwardList = user.AwardList;
                }
            }
        }
    }
}
