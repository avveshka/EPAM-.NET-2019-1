using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class User
    {
        private static int countUsers = 0;
        private string _firstName;
        private string _lastName;
        private DateTime _birthDay;
        public List<Award> AwardList = new List<Award>();
        public string UserShowAward = "";

        public User(string firstName, string lastName, DateTime birthday)
        {
            countUsers++;
            ID = countUsers;
            FirstName = firstName;
            LastName = lastName;
            BirthDay = birthday;
        }

        public User(string firstName, string lastName, DateTime birthday, List<Award> awardList)
        {
            countUsers++;
            ID = countUsers;
            FirstName = firstName;
            LastName = lastName;
            BirthDay = birthday;
            AwardList = awardList;
            foreach (var item in awardList)
            {
                UserShowAward += item.Title;
                UserShowAward += " ";
            }
        }

        public string ShowAwardUser
        {
            get
            {
                return UserShowAward;
            }
            set
            {
                UserShowAward = value;
            }
        }

        public int ID { get; set; }

        public DateTime BirthDay
        {
            get
            {
                return _birthDay;
            }
            set
            {
                if (DateTime.Today.Year - value.Year < 0 || DateTime.Today.Year - value.Year > 150)
                {
                    throw new ArgumentException("Дата рождения введена некорректно");
                }
                _birthDay = value;
            }
        }

        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                if (value.Length > 50)
                {
                    throw new ArgumentException("имя слишком длинное");
                }
                _firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                if (value.Length > 50)
                {
                    throw new ArgumentException("фамилия слишком длинное");
                }
                _lastName = value;
            }
        }

        public int Age
        {
            get
            {
                int age = 0;
                age = DateTime.Today.Year - BirthDay.Year - 1;
                if (DateTime.Today.Month - BirthDay.Month > 0 || (DateTime.Today.Month - BirthDay.Month == 0 && DateTime.Today.Day - BirthDay.Day >= 0))
                {
                    age++;
                }
                return age;
            }
        }

        public void AddAward(Award award)
        {
            if (AwardList.Count != 0)
            {
                UserShowAward += ",";
            }
            AwardList.Add(award);
            UserShowAward += award.Title;
        }

        public void UserShowAwardInicialization()
        {
            UserShowAward = "";
            foreach (var item in AwardList)
            {
                UserShowAward += item.Title;
                UserShowAward += " ";
            }
        }
    }
}
