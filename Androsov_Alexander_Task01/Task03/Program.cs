using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Введите количество строк : ");
            var countString = int.Parse(Console.ReadLine());
            if (countString <= 0)
            {
                Console.WriteLine("Число строк не может быть отрицаиельным или равным нулю!");
                Console.ReadKey();
                return;
            }
            for (var i = 0; i < countString; i++)
            {
                string space = new string(' ', countString - i - 1);
                Console.Write(space);
                string star = new string('*', i + i +1);
                Console.WriteLine(star);
            }
            Console.ReadKey();
        }
    }
}
