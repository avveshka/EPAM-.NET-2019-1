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
            var Border = 1000;
            var Sum = 0;
            for (var i = 0; i < Border; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    Sum += i;
                }
            }
            Console.WriteLine($"Сумма всех чисел кратных 3 или 5 до 1000 = {Sum}");
            Console.ReadKey();
        }
    }
}
