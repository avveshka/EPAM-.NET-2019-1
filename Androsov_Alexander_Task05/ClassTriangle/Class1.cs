using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTriangle
{
    public class Triangle
    {
        private float _a;
        private float _b;
        private float _c;

        public Triangle(float a,float b,float c)
        {
            A = a;
            B = b;
            C = c;
        }
        
        public float A
        {
            private set
            {
                if(value <= 0 )
                {
                    throw new Exception("Сторона A должна быть положительной");
                }
                if(value > B + C)
                {
                    throw new Exception("Сторона A больше двух других");
                }
                _a = value;
            }
            get
            {
                return _a;
            }
        }

        public float B
        {
            private set
            {
                if (value <= 0)
                {
                    throw new Exception("Сторона B должна быть положительной");
                }
                if (value > A + C)
                {
                    throw new Exception("Сторона B больше двух других");
                }
                _b = value;
            }
            get
            {
                return _b;
            }
        }

        public float C
        {
            private set
            {
                if (value <= 0)
                {
                    throw new Exception("Сторона C должна быть положительной");
                }
                if (value > B + A)
                {
                    throw new Exception("Сторона C больше двух других");
                }
                _c = value;
            }
            get
            {
                return _c;
            }
        }

        public float Perimeter()
        {
            var perimeter = 0f;
            perimeter = _a + _b + _c;
            return perimeter;
        }

        public double Square()
        {
            var square = 0d;
            var perimeter = Perimeter() / 2;
            square = Math.Sqrt(perimeter * (perimeter - _a) * (perimeter - _b) * (perimeter - _c));
            return square;
        }
    }
}
