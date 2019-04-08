using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFunctions
{
    public class Pow
    {
        public int Get(int number, int pow)
        {
            int start = number;
            for (int i = 0; i < pow - 1; i++)
            {
                number *= start;
            }
            return number;
        }
    }
}
