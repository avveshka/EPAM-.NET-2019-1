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
            Console.Write("Введите сторону A прямоугольника : ");
            var width = int.Parse(Console.ReadLine());
            Console.Write("Введите сторону B прямоугольника : ");
            var length = int.Parse(Console.ReadLine());
            if (width <= 0 || length <= 0)
            {
                Console.WriteLine("Ошибка.Стороны не могут быть отрицательными или нулевыми!");
                Console.ReadKey();
                return;
            }
            Console.WriteLine($"Площадь прямоугольника с заданными сторонами = {length * width}");
            Console.ReadKey();
        }
    }
}
