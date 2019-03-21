using ClassGgeometricProgression;
using DemoApplication;
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
            ISeries progression = new GgeometricProgression(2, 2);
            Console.WriteLine("Прогрессия:");
            InterfacesDemo.PrintSeries(progression);
            Console.ReadKey();
        }
    }
}
