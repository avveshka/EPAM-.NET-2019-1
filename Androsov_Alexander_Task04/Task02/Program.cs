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
            string firstString = "";
            string secondString = "";
            StringBuilder finalString = new StringBuilder();
            Console.Write("Введи первую строку :");
            firstString = Console.ReadLine();
            Console.Write("Введи вторую строку :");
            secondString = Console.ReadLine();
            foreach (char letter in firstString)
            {
                if (secondString.Contains(letter))
                {
                    finalString.Append(letter);
                }

                finalString.Append(letter);

            }
            Console.WriteLine($"Финальная строка = {finalString}");
            Console.ReadKey();
        }
    }
}
