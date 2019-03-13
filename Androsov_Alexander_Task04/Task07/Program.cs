using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст со временем : ");
            string input = Console.ReadLine();
            string pattern = @"(([0-23])|(0[0-9])):(([0-5][0-9])|(60))";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);
            Console.WriteLine($"Во введённой строке {matches.Count} раз встречается время");
            Console.ReadKey();
        }
    }
}
