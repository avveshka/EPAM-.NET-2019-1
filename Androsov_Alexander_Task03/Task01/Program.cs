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
            Console.Write("Введите строку : ");
            string input = Console.ReadLine();
            char[] exception = { ' ', ',', ':', ';', '?', '.', '/', '\t', '*' };
            string[] words = input.Split(exception, StringSplitOptions.RemoveEmptyEntries);
            var temp = 0f;
            var forParse = 0;
            var wordcount = 0f;
            foreach (string word in words)
            {
                if (!int.TryParse(word, out forParse))
                {
                    temp += word.Length;
                    wordcount++;
                    Console.WriteLine($"Слово {word} длинной - {word.Length}");
                }
            }
            Console.WriteLine($"Средняя длинна слов = {temp / wordcount}");
            Console.ReadKey();
        }
    }
}
