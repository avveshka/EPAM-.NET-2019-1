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
        public Triangle(string a, string b, string c)
        {
            if (float.TryParse(a, out var floatA) && float.TryParse(b, out var floatB) && float.TryParse(c, out var floatC))
            {
                if (floatA <= 0 || floatB <= 0 || floatC <= 0)
                {
                    throw new Exception("Стороны должны быть положительными");
                }
                if ((floatA + floatB) < floatC || (floatB + floatC) < floatA || (floatC + floatA) < floatB)
                {
                    throw new Exception("Две стороны в сумме не может быть меньше третьей");
                }
                _a = floatA;
                _b = floatB;
                _c = floatC;
            }
            else
            {
                throw new Exception("Стороны должны быть числвми");
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
