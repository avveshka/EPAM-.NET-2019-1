using ClassEmployee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime birthday = new DateTime(1978, 11, 06);
            Employee myFather = new Employee("Вячеслав", "Андросов", "Викторович", birthday, 20, "Директор");
            myFather = null;
            Console.WriteLine($"Сравнение двух одинаковых объектов - {myFather.Equals(myFather)}");
            Console.ReadKey();
        }
    }
}
