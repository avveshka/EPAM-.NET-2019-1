using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassUser
{
    public class User
    {
        public string Name;
        public string Surname;
        public string Patronymic;
        private DateTime _birthday;
        private int _old;

        public User(string name, string surname, string patronymic, DateTime birthday)
        {
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            _birthday = birthday;
        }
        public int Old
        {
            get
            {
                _old = DateTime.Today.Year - _birthday.Year - 1;
                if (DateTime.Today.Month - _birthday.Month > 0 || (DateTime.Today.Month - _birthday.Month == 0 && DateTime.Today.Day - _birthday.Day >= 0))
                {
                    _old++;
                }
                return _old;
            }
        }
    }
}


