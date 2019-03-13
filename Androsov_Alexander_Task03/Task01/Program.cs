using HelperFunction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Program
    {
        static int[] SortArray(int[] array)
        {
            int temp = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return array;
        }
        static void Main(string[] args)
        {
            int[] array = new int[10];
            array = HelperFunctions.RandomFunction(array);
            array = SortArray(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"array[{i}] = {array[i]} ");
            }
            Console.WriteLine($"Минимальное значение = {array[0]}");
            Console.WriteLine($"Максимальное значение = {array[array.Length - 1]}");
            Console.ReadKey();
        }
    }
}
