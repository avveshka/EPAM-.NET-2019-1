using ClassCircle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRound
{
    public class Round : Circle
    {
        public Round(int x, int y, int radius)
            : base(x, y, radius)
        {
        }
        public virtual double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
        public override void Draw()
        {
            Console.WriteLine($"Круг с центром в x:{centerX} y:{centerY}, радиусои - {Radius} и площадью {GetArea()}");
        }
    }
}
