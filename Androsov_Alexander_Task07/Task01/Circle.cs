using ClassFigure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCircle
{
    public class Circle : Figure
    {
        private int _radius;
        public Circle(int x, int y, int radius)
        {
            X = x;
            Y = y;
            Radius = radius;
        }
        public int Radius
        {
            set
            {
                if (value > 0)
                {
                    _radius = value;
                }
                else
                {
                    throw new Exception("Радиус должен быть больше нуля");
                }
            }
            get
            {
                return _radius;
            }
        }
        public double CircleLength()
        {
            return 2 * Math.PI * _radius;
        }
        public override void Draw()
        {
            Console.WriteLine($"Окружность с центром в координате x:{centerX} y:{centerY}, радиусом - {Radius} и длиной окружности - {CircleLength()}");
        }
    }
}
