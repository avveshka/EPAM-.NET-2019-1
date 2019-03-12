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
        static void Main(string[] args)
        {
            int[] array = new int[10];
            array = HelperFunctions.RandomFunction(array);
            Array.Sort(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"array[{i}] = {array[i]} ");
            }
            Console.WriteLine($"Минимальное значение = {array[0]}");
            Console.WriteLine($"Максимальное значение = {array[array.Length-1]}");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
