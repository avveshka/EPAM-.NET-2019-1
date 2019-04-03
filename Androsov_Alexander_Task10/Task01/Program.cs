using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Program
    {
        public delegate bool SortDelegate(string str1, string str2);
        static void Main(string[] args)
        {
            var source = new string[] { "qwerty", "qwe", "asdf", "asdfgh", "asd", "zxcvbnmasd", "qwertyuioasdfghjklzxcvbnm", "a", "sd" };
            source = Sort(source,Comparison);
            for (int i = 0; i < source.Length; i++)
            {
                Console.WriteLine(source[i]);
            }
            Console.ReadKey();
        }

        public static string[] Sort(string[] forSort, SortDelegate sortDelegate)
        {
            string temp;
            for (int i = 0; i < forSort.Length; i++)
            {
                for (int j = forSort.Length-1; j > i; j--)
                {
                    if (sortDelegate(forSort[j - 1], forSort[j]))
                    {
                        temp = forSort[j - 1];
                        forSort[j - 1] = forSort[j];
                        forSort[j] = temp;
                    }
                }
            }
            return forSort;
        }

        public static bool Comparison(string str1, string str2)
        {
            if (str1.Length > str2.Length)
            {
                return true;
            }
            if (str1.Length < str2.Length)
            {
                return false;
            }
            char[] arr1 = str1.ToCharArray();
            char[] arr2 = str2.ToCharArray();
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] > arr2[i])
                {
                    return true;
                }
                if (arr1[i] < arr2[i])
                {
                    return false;
                }
            }
            return true;
        }

        public static bool ComparisonReverse(string str1, string str2)
        {
            if (str1.Length < str2.Length)
            {
                return true;
            }
            if (str1.Length > str2.Length)
            {
                return false;
            }
            char[] arr1 = str1.ToCharArray();
            char[] arr2 = str2.ToCharArray();
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] < arr2[i])
                {
                    return true;
                }
                if (arr1[i] > arr2[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
