using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Введите количество триугольников : ");
            var countTriangle = int.Parse(Console.ReadLine());
            if (countTriangle <= 0)
            {
                Console.WriteLine("Число триугольников не может быть отрицаиельным или равным нулю!");
                Console.ReadKey();
                return;
            }
            for (var i = 0; i < countTriangle; i++)
            {
                for (var j = 0; j <= i; j++)
                {
                    string space = new string(' ', countTriangle - j - 1);
                    Console.Write(space);
                    string star = new string('*', j + j + 1);
                    Console.WriteLine(star);
                }
            }
            Console.ReadKey();
        }
    }
}