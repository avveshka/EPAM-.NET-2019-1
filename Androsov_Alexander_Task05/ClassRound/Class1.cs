using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRound
{
    public class Round
    {
        private int _centerCoordinateX;
        private int _centerCoordinateY;
        private int _radius;
        private double _circleLength;
        private double _circleSquare;

        public Round(int x, int y, int radius)
        {
            _centerCoordinateX = x;
            _centerCoordinateY = y;
            if(radius<=0)
            {
                throw new Exception("Радиус должен быть положительным");
            }
            {
                _radius = radius;
            }
            CircleLength = radius;
            CircleSquare = radius;
        }



        public double CircleLength
        {
            get
            {
                return _circleLength;
            }
            set
            {
                _circleLength = 2 * 3.14 * value;
            }
        }

        public double CircleSquare
        {
            get
            {
                return _circleSquare;
            }
            set
            {
                _circleSquare = 3.14 * value * value;
            }
        }
    }
}
