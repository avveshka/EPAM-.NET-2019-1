using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
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
        public static UserList ListUser = new UserList();
        public static AwardList ListAward = new AwardList();

        public static void Initializestorage()
        {
            ListUser.ListUsers.Add(new User("Александр", "Андросов", new DateTime(1998, 09, 13)));
            ListUser.ListUsers.Add(new User("Василий", "Гривин", new DateTime(1998, 06, 21)));
            ListUser.ListUsers.Add(new User("Илья", "Паненков", new DateTime(1998, 11, 6)));
            ListAward.ListAwards.Add(new Award("Оскар", "За лучший фильм или роль"));
            ListAward.ListAwards.Add(new Award("Нобелевская премия", "За выдающиеся открытия в сфере науки"));
            ListAward.ListAwards.Add(new Award("Букеровская премия"));
            ListUser.ListUsers[0].AddAward(GetAwardByTitle("Оскар"));
            ListUser.ListUsers[0].AddAward(GetAwardByTitle("Нобелевская премия"));
            ListUser.ListUsers[1].AddAward(GetAwardByTitle("Оскар"));
            ListUser.ListUsers[2].AddAward(GetAwardByTitle("Оскар"));
            ListUser.ListUsers[1].AddAward(GetAwardByTitle("Букеровская премия"));
        }
        //public static BindingList<Award> ListAward { get => listAward; set => listAward = value; }
        //public static BindingList<User> ListUser { get => listUser; set => listUser = value; }

        public static Award GetAwardByTitle(string title)
        {
            Award temp;
            foreach (var item in ListAward.ListAwards)
            {
                if (item.Title.Equals(title))
                {
                    temp = item;
                    return temp;
                }
            }
            return (new Award("Премия Дарвиа"));
        }

        public static BindingList<User> SortUser(int columnIndex)
        {
            switch (columnIndex)
            {
                case 0:
                    {
                        if (_sortModeUsers == SortMode.Asceding)
                        {
                            ListUser.ListUsers = new BindingList<User>(ListUser.ListUsers.OrderByDescending(s => s.FirstName).ToList());
                            _sortModeUsers = SortMode.Desceding;
                        }
                        else
                        {
                            ListUser.ListUsers = new BindingList<User>(ListUser.ListUsers.OrderBy(s => s.FirstName).ToList());
                            _sortModeUsers = SortMode.Asceding;
                        }
                        return ListUser.ListUsers;
                    }
                case 1:
                    {
                        if (_sortModeUsers == SortMode.Asceding)
                        {
                            ListUser.ListUsers = new BindingList<User>(ListUser.ListUsers.OrderByDescending(s => s.LastName).ToList());
                            _sortModeUsers = SortMode.Desceding;
                        }
                        else
                        {
                            ListUser.ListUsers = new BindingList<User>(ListUser.ListUsers.OrderBy(s => s.LastName).ToList());
                            _sortModeUsers = SortMode.Asceding;
                        }
                        return ListUser.ListUsers;
                    }
                case 2:
                    {
                        if (_sortModeUsers == SortMode.Asceding)
                        {
                            ListUser.ListUsers = new BindingList<User>(ListUser.ListUsers.OrderByDescending(s => s.Age).ToList());
                            _sortModeUsers = SortMode.Desceding;
                        }
                        else
                        {
                            ListUser.ListUsers = new BindingList<User>(ListUser.ListUsers.OrderBy(s => s.Age).ToList());
                            _sortModeUsers = SortMode.Asceding;
                        }
                        return ListUser.ListUsers;
                    }
                default:
                    throw new ArgumentException();
            }
        }

        public static BindingList<Award> SortAward()
        {
            if (_sortModeAwards == SortMode.Asceding)
            {
                ListAward.ListAwards = new BindingList<Award>(ListAward.ListAwards.OrderByDescending(s => s.Title).ToList());
                _sortModeAwards = SortMode.Desceding;
            }
            else
            {
                ListAward.ListAwards = new BindingList<Award>(ListAward.ListAwards.OrderBy(s => s.Title).ToList());
                _sortModeAwards = SortMode.Asceding;
            }
            return ListAward.ListAwards;
        }

        public static void EditUser(User user, string firstname, string lastname, DateTime birthday, List<Award> awards)
        {
            ListUser.ListUsers.Remove(user);
            ListUser.ListUsers.Add(new User(firstname, lastname, birthday));
            foreach (var item in awards)
            {
                ListUser.ListUsers[ListUser.ListUsers.Count - 1].AddAward(item);
            }
        }

        public static void EditAward(Award award, string title, string description)
        {
            ListAward.ListAwards.Remove(award);
            if (description == null)
            {
                ListAward.ListAwards.Add(new Award(title));
            }
            else
            {
                ListAward.ListAwards.Add(new Award(title, description));
            }
        }

        public static BindingList<User> GetUserList()
        {
            return ListUser.ListUsers;
        }

        public static BindingList<Award> GetAwardList()
        {
            return ListAward.ListAwards;
        }

        public static void AddAwardForLastUser(Award award)
        {
            ListUser.ListUsers[ListUser.ListUsers.Count - 1].AddAward(award);
        }

        public static void AddUserToList(User user)
        {
            ListUser.ListUsers.Add(user);
        }

        public static void RemoveUserFromList(User user)
        {
            ListUser.ListUsers.Remove(user);
        }

        public static void AddAwardToList(Award award)
        {
            ListAward.ListAwards.Add(award);
        }
    
        public static void RemoveAwardFromList(Award award)
        {
            ListAward.ListAwards.Remove(award);
            for (int i = 0; i < ListUser.ListUsers.Count; i++)
            {
                if (ListUser.ListUsers[i].AwardList.Contains(award))
                {
                    ListUser.ListUsers[i].AwardList.Remove(award);
                    ListUser.ListUsers[i].UserShowAwardInicialization();
                }
            }
        }
    }
}