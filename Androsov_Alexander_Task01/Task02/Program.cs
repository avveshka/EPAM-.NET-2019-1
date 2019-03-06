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
            var countstring = int.Parse(Console.ReadLine());
            if (countstring <= 0)
            {
                Console.WriteLine("Число строк не может быть отрицаиельным или равным нулю!");
                Console.ReadKey();
                return;
            }
            for (var i = 0; i < countstring; i++)
            {
                string star = new string('*', i+1);
                Console.WriteLine(star);
            }
            Console.ReadKey();
        }
    }
}
