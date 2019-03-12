using HelperFunction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
    class Program
    {
        static int SumArray(int[,] array)
        {
            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        sum += array[i, j];
                    }
                }
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int[,] array = new int[5, 5];
            array = HelperFunctions.RandomFunction(array);
            for (int i = 0; i < array.GetLength(1); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"array[{i + 1},{j + 1}] = {array[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Сумма элементов с четной суммой индексов равна = {SumArray(array)}");
            Console.ReadKey();
        }
    }
}
