using ClassFigure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLine
{
    public class Line : Figure
    {
        private int _length;
        public Line(int x, int y, int length)
        {
            centerX = x;
            centerY = y;
            Length = length;
        }
        public int Length
        {
            set
            {
                if (value > 0)
                {
                    _length = value;
                }
                else
                {
                    throw new Exception("Длинна долдна быть больше 0");
                }
            }
            get
            {
                return _length;
            }
        }
        public override void Draw()
        {
            Console.WriteLine($"Это линия с центром в координате x:{centerX} y:{centerY} и длинной {Length}");
        }
    }
}
