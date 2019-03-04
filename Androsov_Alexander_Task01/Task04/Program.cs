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
            var CountTriangle = int.Parse(Console.ReadLine());
            if (CountTriangle <= 0)
            {
                Console.WriteLine("Число триугольников не может быть отрицаиельным или равным нулю!");
                Console.ReadKey();
                return;
            }
            for (var i = 0; i < CountTriangle; i++)
            {
                for (var j = 0; j <= i; j++)
                {
                    for (var k = 0; k < (CountTriangle - j - 1); k++)
                    {
                        Console.Write(" ");
                    }
                    for (var k = 0; k <= j + j; k++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
        }
    }
}