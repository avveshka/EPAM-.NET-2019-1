using ClassEmployee;
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
            DateTime birthday = new DateTime(1978, 11, 06);
            Employee myFather = new Employee("Вячеслав","Андросов","Викторович",birthday,20,"Директор");
            Console.WriteLine($"Работника зовут - {myFather.Surname} {myFather.Name} {myFather.Patronymic}. Ему {myFather.Old} лет");
            Console.WriteLine($"Его долюжность - {myFather.Position}. Его зарплата - {myFather.Pay}, а премия - {myFather.Premium}");
            Console.ReadKey();
        }
    }
}
