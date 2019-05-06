using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace Task14
{
    public class Storage
    {
        private enum SortMode { Asceding, Desceding };
        private static SortMode _sortModeUsers = SortMode.Asceding;
        private static SortMode _sortModeAwards = SortMode.Asceding;
        //private static BindingList<User> listUser = new BindingList<User>();
        //private static BindingList<Award> listAward = new BindingList<Award>();
        public static /*UserSqlList*/IUserStorage ListUser;// = new UserSqlList(DataSetting.Connection);
        public static /*AwardSqlList*/IAwardStorage ListAward;// = new AwardSqlList(DataSetting.Connection);

        public static void Initializestorage()
        {
            if (ConfigurationManager.AppSettings["useSQL"] == "true")
            {
                ListUser = new UserSqlList(DataSetting.Connection);
                ListAward = new AwardSqlList(DataSetting.Connection);
            }
            else
            {
                ListUser = new UserList();
                ListAward = new AwardList();
                ListUser.Add(new User("Александр", "Андросов", new DateTime(1998, 09, 13)));
                ListUser.Add(new User("Василий", "Гривин", new DateTime(1998, 06, 21)));
                ListUser.Add(new User("Илья", "Паненков", new DateTime(1998, 11, 6)));
                ListAward.Add(new Award(1, "Оскар", "За лучший фильм или роль"));
                ListAward.Add(new Award(2, "Нобелевская премия", "За выдающиеся открытия в сфере науки"));
                ListAward.Add(new Award(3, "Букеровская премия"));
                ListUser.AddAward(GetAwardByTitle("Оскар"), 0);
                ListUser.AddAward(GetAwardByTitle("Нобелевская премия"), 0);
                ListUser.AddAward(GetAwardByTitle("Оскар"), 1);
                ListUser.AddAward(GetAwardByTitle("Оскар"), 2);
                ListUser.AddAward(GetAwardByTitle("Букеровская премия"), 1);
            }
        }
        //public static BindingList<Award> ListAward { get => listAward; set => listAward = value; }
        //public static BindingList<User> ListUser { get => listUser; set => listUser = value; }

        public static Award GetAwardByTitle(string title)
        {
            Award temp;
            foreach (var item in ListAward.GetList())
            {
                if (item.Title.Equals(title))
                {
                    temp = item;
                    return temp;
                }
            }
            throw new Exception();
        }

        public static BindingList<User> SortUser(int columnIndex)
        {
            var temp = ListUser.GetList();
            switch (columnIndex)
            {
                case 0:
                    {
                        if (_sortModeUsers == SortMode.Asceding)
                        {
                            temp = new BindingList<User>(ListUser.GetList().OrderByDescending(s => s.FirstName).ToList());
                            _sortModeUsers = SortMode.Desceding;
                        }
                        else
                        {
                            temp = new BindingList<User>(ListUser.GetList().OrderBy(s => s.FirstName).ToList());
                            _sortModeUsers = SortMode.Asceding;
                        }
                        return temp;
                    }
                case 1:
                    {
                        if (_sortModeUsers == SortMode.Asceding)
                        {
                            temp = new BindingList<User>(ListUser.GetList().OrderByDescending(s => s.LastName).ToList());
                            _sortModeUsers = SortMode.Desceding;
                        }
                        else
                        {
                            temp = new BindingList<User>(ListUser.GetList().OrderBy(s => s.LastName).ToList());
                            _sortModeUsers = SortMode.Asceding;
                        }
                        return temp;
                    }
                case 2:
                    {
                        if (_sortModeUsers == SortMode.Asceding)
                        {
                            temp = new BindingList<User>(ListUser.GetList().OrderByDescending(s => s.Age).ToList());
                            _sortModeUsers = SortMode.Desceding;
                        }
                        else
                        {
                            temp = new BindingList<User>(ListUser.GetList().OrderBy(s => s.Age).ToList());
                            _sortModeUsers = SortMode.Asceding;
                        }
                        return temp;
                    }
                default:
                    throw new ArgumentException();
            }
        }

        public static BindingList<Award> SortAward()
        {
            var temp = ListAward.GetList();
            if (_sortModeAwards == SortMode.Asceding)
            {
                temp = new BindingList<Award>(ListAward.GetList().OrderByDescending(s => s.Title).ToList());
                _sortModeAwards = SortMode.Desceding;
            }
            else
            {
                temp = new BindingList<Award>(ListAward.GetList().OrderBy(s => s.Title).ToList());
                _sortModeAwards = SortMode.Asceding;
            }
            return temp;
        }

        public static void EditUser(User user, string firstname, string lastname, DateTime birthday, List<Award> awards)
        {
            user.FirstName = firstname;
            user.LastName = lastname;
            user.BirthDay = birthday;
            user.AwardList = awards;
            ListUser.EditUser(user);
        }

        public static void EditAward(Award award, string title, string description)
        {
            if (description != null)
            {
                award.Description = description;
            }
            award.Title = title;
            ListAward.EditAward(award);
        }

        public static BindingList<User> GetUserList()
        {
            return ListUser.GetList();
        }

        public static BindingList<Award> GetAwardList()
        {
            return ListAward.GetList();
        }

        public static void AddUserToList(User user)
        {
            ListUser.Add(user);
        }

        public static void RemoveUserFromList(User user)
        {
            ListUser.Remove(user);
        }

        public static void AddAwardToList(Award award)
        {
            ListAward.Add(award);
        }
    
        public static void RemoveAwardFromList(Award award)
        {
            ListAward.Remove(award);
            ListUser.DeleteAwardFromUser(award);
        }
    }
}