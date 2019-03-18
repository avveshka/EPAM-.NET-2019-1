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
        private double _innerCircleLength;
        private double _innerCircleSquare;
        public Ring(int x, int y, int radius, int innerRadius)
            : base(x, y, radius)
        {
            InnerRadius = innerRadius;
            _innerCircleLength = 2 * 3.14 * innerRadius;
            _innerCircleSquare = 3.14 * innerRadius * innerRadius;
        }
        public int InnerRadius
        {
            set
            {
                if (value > _radius)
                {
                    throw new Exception("Внутренний радиус не может быть больше внешнего");
                }
                _innerRadius = value;
            }
            get
            {
                return _innerRadius;
            }
        }
        public override double CircleLength
        {
            get
            {
                return _innerCircleLength + base.CircleLength;
            }
        }
        public override double CircleSquare
        {
            get
            {
                return base.CircleSquare - _innerCircleSquare;
            }
        }
    }
}
