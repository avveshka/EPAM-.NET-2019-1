using MathFunctions;
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
            Factorial fact = new Factorial();
            Pow pow = new Pow();
            Console.WriteLine($"Факториал 5 равен {fact.Get(5)}");
            Console.WriteLine($"2 в степени 8 равно {pow.Get(2,8)}");
            Console.ReadKey();
        }
    }
}
