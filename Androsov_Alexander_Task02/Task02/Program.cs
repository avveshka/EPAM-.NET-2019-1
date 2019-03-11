using HelperFunction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class Program
    {
        static int[,,] ChangeToZero(int[,,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        if (array[i, j, k] < 0)
                        {
                            array[i, j, k] = 0;
                        }
                    }
                }
            }
            return array;
        }
        static void Main(string[] args)
        {
            int[,,] array = new int[5, 5, 5];
            array = HelperFunctions.RandomFunction(array);
            array = ChangeToZero(array);
            Console.ReadKey();
        }
    }
}
