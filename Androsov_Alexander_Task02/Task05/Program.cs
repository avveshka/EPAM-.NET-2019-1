using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            var border = 1000;
            var sum = 0;
            for (var i = 0; i < border; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine($"Сумма всех чисел кратных 3 или 5 до 1000 = {sum}");
            Console.ReadKey();
        }
    }
}
