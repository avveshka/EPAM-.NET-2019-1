using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperFunction
{
    public class HelperFunctions
    {
        public static int[] RandomFunction(int[] RandomArray)
        {
            Random random = new Random();
            for (int i = 0; i < RandomArray.Length; i++)
            {
                RandomArray[i] = random.Next(-10, 10);
            }
            return RandomArray;
        }
        public static int[,] RandomFunction(int[,] RandomArray)
        {
            Random random = new Random();
            for (int i = 0; i < RandomArray.GetLength(0); i++)
            {
                for (int j = 0; j < RandomArray.GetLength(1); j++)
                {
                    RandomArray[i, j] = random.Next(-10, 10);
                }
            }
            return RandomArray;
        }
        public static int[,,] RandomFunction(int[,,] RandomArray)
        {
            Random random = new Random();
            for (int i = 0; i < RandomArray.GetLength(0); i++)
            {
                for (int j = 0; j < RandomArray.GetLength(1); j++)
                {
                    for (int k = 0; k < RandomArray.GetLength(2); k++)
                    {
                        RandomArray[i, j, k] = random.Next(-10, 10);
                    }
                }
            }
            return RandomArray;
        }
    }
}
