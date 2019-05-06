using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IUserStorage
    {
        void Add(User user);

        void Remove(User user);

        void DeleteAwardFromUser(Award award);

        BindingList<User> GetList();

        void AddAward(Award award, int pos);

        void EditUser(User user);
    }
}
