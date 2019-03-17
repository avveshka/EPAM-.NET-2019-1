using ClassUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            User me = new User("Александр","Андросов","Вячеславович","1998","13","09");
            Console.WriteLine($"Пользователя зовут {me.Surname} {me.Name} {me.Patronymic} и ему {me.Old} лет");
            Console.ReadKey();
        }
    }
}
