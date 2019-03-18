using ClassRing;
using ClassRound;
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
            Ring ring = new Ring(2, 3, 5, 4);
            Console.WriteLine($"Длинна кольца - {ring.CircleLength}");
            Console.WriteLine($"Площадь кольца - {ring.CircleSquare}");
            Console.ReadKey();
        }
    }
}
