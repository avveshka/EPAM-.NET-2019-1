using ClassRound;
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
            Console.Write("Введите X координату центра окружности: ");
            string x = Console.ReadLine();
            Console.Write("Введите Y координату центра окружности: ");
            string y = Console.ReadLine();
            Console.Write("Введите радиус окружности: ");
            string radius = Console.ReadLine();
            Round round = new Round(x, y, radius);
            Console.WriteLine($"Площадь круга = {round.CircleSquare}. Длинна окуржности = {round.CircleLength}");
            Console.ReadKey();
        }
    }
}
