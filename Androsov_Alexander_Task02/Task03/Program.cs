using HelperFunction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    class Program
    {
        static int Sum(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    sum += array[i];
                }
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int[] array = new int[10];
            array = HelperFunctions.RandomFunction(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"array[{i + 1}] = {array[i]}");
            }
            Console.WriteLine($"Сумма неотрицательных элементов = {Sum(array)}");
            Console.ReadKey();
        }
    }
}
