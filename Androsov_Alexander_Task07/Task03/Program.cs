using DemoApplication;
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
            ISeries progression = new ArithmeticalProgression(2, 2);
            ISeries series = new List(new double[]{ 5, 8, 6, 3, 1 });
            Console.WriteLine($"Первый элемент ArithmeticalProgression {((ArithmeticalProgression)progression)[1]}");
            Console.WriteLine($"Первый элемент List {((List)series)[1]}");
            Console.ReadKey();
        }
    }
}
