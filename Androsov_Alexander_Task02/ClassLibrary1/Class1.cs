using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperFunction
{
    public class HelperFunctions
    {
        public static int[] RandomFunction(int[] randomarray)
        {
            Random random = new Random();
            for (int i = 0; i < randomarray.Length; i++)
            {
                randomarray[i] = random.Next(-10, 10);
            }
            return randomarray;
        }
        public static int[,] RandomFunction(int[,] randomarray)
        {
            Random random = new Random();
            for (int i = 0; i < randomarray.GetLength(0); i++)
            {
                for (int j = 0; j < randomarray.GetLength(1); j++)
                {
                    randomarray[i, j] = random.Next(-10, 10);
                }
            }
            return randomarray;
        }
        public static int[,,] RandomFunction(int[,,] randomarray)
        {
            Random random = new Random();
            for (int i = 0; i < randomarray.GetLength(0); i++)
            {
                for (int j = 0; j < randomarray.GetLength(1); j++)
                {
                    for (int k = 0; k < randomarray.GetLength(2); k++)
                    {
                        randomarray[i, j, k] = random.Next(-10, 10);
                    }
                }
            }
            return randomarray;
        }
    }
}
