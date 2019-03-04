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
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Введите количество строк : ");
            var CountString = int.Parse(Console.ReadLine());
            if (CountString <= 0)
            {
                Console.WriteLine("Число строк не может быть отрицаиельным или равным нулю!");
                Console.ReadKey();
                return;
            }
            for (var i = 0; i < CountString; i++)
            {
                for (var j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
