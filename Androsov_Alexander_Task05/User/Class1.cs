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
        public int Old;
        public User(string name, string surname, string patronymic, string year, string day, string month)
        {
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            if (int.TryParse(year, out int intyear) && int.TryParse(month, out int intmonth) && int.TryParse(day, out int intday))
            {
                _birthday = new DateTime(intyear, intmonth, intday);
            }
            else
            {
                throw new Exception("Дата рождения должна быть числом");
            }
            Old = DateTime.Today.Year - _birthday.Year - 1;
            if (DateTime.Today.Month - _birthday.Month > 0 || (DateTime.Today.Month - _birthday.Month == 0 && DateTime.Today.Day - _birthday.Day >= 0))
            {
                Old++;
            }
        }
    }
}
