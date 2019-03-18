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
            DateTime birthday = new DateTime(1998, 09, 13);
            User me = new User("Александр", "Андросов", "Вячеславович", birthday);
            Console.WriteLine($"Пользователя зовут {me.Surname} {me.Name} {me.Patronymic} и ему {me.Old} лет");
            Console.ReadKey();
        }
    }
}
