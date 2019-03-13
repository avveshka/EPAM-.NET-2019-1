using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            string Pattern = @"<[^>]*>";
            Regex regex = new Regex(Pattern);
            Console.WriteLine("Введите любую строку с использование HTML-тегов : ");
            string result = regex.Replace(Console.ReadLine(), "_");
            Console.WriteLine("Результирующая строка после замены HTML-тегов на знак \"_\"");
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
