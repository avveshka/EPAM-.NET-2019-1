using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UserList : IStorage
    {
        public BindingList<User> ListUsers;

        public UserList()
        {
            ListUsers = new BindingList<User>();
        }
    }
}
