using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите вещественное число : ");
            string input = Console.ReadLine();
            string patternCommon = @"((-[0-9]*)|([0-9]*))\.[0-9]*";
            string patternScience = @"((-[0-9]*)|([0-9]*))\.[0-9]*e((-[0-9]*)|([0-9]*))";
            Regex regexCommon = new Regex(patternCommon);
            Regex regexScience = new Regex(patternScience);
            if (regexScience.IsMatch(input))
            {
                Console.WriteLine("Это научная нотация");
            }
            else if (regexCommon.IsMatch(input))
            {
                Console.WriteLine("Это обычная нотация");
            }
            else
            {
                Console.WriteLine("Это не число");
            }
            Console.ReadKey();
        }
    }
}
