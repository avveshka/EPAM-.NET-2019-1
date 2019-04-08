using ClassUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEmployee
{
    public class Employee : User, IEquatable<Employee>
    {
        private int _experience;
        public string Position;
        private double _pay;
        private double _premium;

        public Employee(string name, string surname, string patronymic, DateTime birthday, int experience, string position)
            : base(name, surname, patronymic, birthday)
        {
            Experience = experience;
            Position = position;
            Pay = 0;
            Premium = 0;
        }

        public int Experience
        {
            set
            {
                if (value < 0)
                {
                    throw new Exception("Стаж не может быть меньше нуля");
                }
                if (value > Old - 18)
                {
                    throw new Exception("Стаж не может быть больше возраста");
                }
                _experience = value;
            }
            get
            {
                return _experience;
            }
        }

        public double Pay
        {
            set
            {
                if (Position == "Директор")
                {
                    _pay = 1000000;
                }
                else
                {
                    _pay = 30000;
                }
            }
            get
            {
                return _pay;
            }
        }

        public double Premium
        {
            set
            {
                if (Old >= 20 && Old < 30)
                {
                    _premium = 3000;
                }
                else
                {
                    if (Old >= 30 && Old < 50)
                    {
                        _premium = 10000;
                    }
                    else
                    {
                        if (Old >= 50)
                        {
                            _premium = 5000;
                        }
                        else
                        {
                            _premium = 0;
                        }
                    }
                }
            }
            get
            {
                return _premium;
            }
        }

        public bool Equals(Employee other)
        {
            if (other == null)
            {
                return false;
            }

            return Name.Equals(other.Name, StringComparison.CurrentCultureIgnoreCase) &&
            Surname.Equals(other.Surname, StringComparison.CurrentCultureIgnoreCase) &&
            Patronymic.Equals(other.Patronymic, StringComparison.CurrentCultureIgnoreCase) &&
            Old == other.Old && Position.Equals(other.Position, StringComparison.CurrentCultureIgnoreCase);
        }
    }
}