using ClassRound;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRing
{
    public class Ring : Round
    {
        private int _innerRadius;
        public Ring(int x, int y, int radius, int innerRadius)
            : base(x, y, radius)
        {
            InnerRadius = innerRadius;
        }
        public int InnerRadius
        {
            set
            {
                if (value > 0)
                {
                    if (value < Radius)
                    {
                        _innerRadius = value;
                    }
                    else
                    {
                        throw new Exception("Внутренний радиус должен быть меньше внешнего");
                    }
                }
                else
                {
                    throw new Exception("Радиус должен быть больше нуля");
                }
            }
            get
            {
                return _innerRadius;
            }
        }
        public override double GetArea()
        {
            return base.GetArea() - (Math.PI * InnerRadius * InnerRadius);
        }
        public override void Draw()
        {
            Console.WriteLine($"Колцо с центром в x:{centerX} y:{centerY}, радиусами внешним - {Radius} и внутренним {InnerRadius} и площадью - {GetArea()}"); ;
        }
    }
}
