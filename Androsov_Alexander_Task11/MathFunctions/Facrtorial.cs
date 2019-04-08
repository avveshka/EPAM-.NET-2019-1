using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFunctions
{
    public class Factorial
    {
        public int Get(int pos)
        {
            int result = 1;
            for (int i = 1; i <= pos; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
