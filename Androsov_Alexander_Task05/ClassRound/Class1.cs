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
        public Round(string xCoordinate, string yCoordinate, string radius)
        {
            if (int.TryParse(xCoordinate, out var intX) && int.TryParse(yCoordinate, out var intY) && int.TryParse(radius, out var intRadius))
            {
                _centerCoordinateX = intX;
                _centerCoordinateY = intY;
                _radius = intRadius;
                _circleLength = 2 * 3.14 * _radius;
                _circleSquare = 3.14 * _radius * _radius;
            }
            else
            {
                throw new Exception("Центр и радиус должны быть числами");
            }
        }
        public double CircleLength
        {
            get
            {
                double circlelength = 0;
                circlelength = _circleLength;
                return circlelength;
            }
        }
        public double CircleSquare
        {
            get
            {
                double circlesquare = 0;
                circlesquare = _circleSquare;
                return circlesquare;
            }
        }
    }
}
