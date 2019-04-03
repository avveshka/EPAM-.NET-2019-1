using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task03
{
    public delegate bool SortDelegate(string str1, string str2);
    public delegate void OnEndSort();

    class Program
    {
        static void Main(string[] args)
        {
            SortInSecondTreath(new string[] { "qwerty", "qwe", "asdf", "asdfgh", "asd", "zxcvbnmasd", "qwertyuioasdfghjklzxcvbnm", "a", "sd" });
            Console.ReadKey();
        }

        public static void Sort(object forSortObj)
        {
            string[] forSort = (string[])forSortObj;
            SortDelegate sortDelegate = new SortDelegate(Comparison);
            string temp;
            for (int i = 0; i < forSort.Length; i++)
            {
                for (int j = forSort.Length - 1; j > i; j--)
                {
                    if (Comparison(forSort[j - 1], forSort[j]))
                    {
                        temp = forSort[j - 1];
                        forSort[j - 1] = forSort[j];
                        forSort[j] = temp;
                    }
                }
            }
            for (int i = 0; i < forSort.Length; i++)
            {
                Console.WriteLine(forSort[i]);
            }
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

        public static void SortInSecondTreath(string[] forsort)
        {
            Thread thread = new Thread(new ParameterizedThreadStart(Sort));
            thread.IsBackground = true;
            thread.Start(forsort);
            Sort(forsort);
            Event evt = new Event();
            while(true)
            {
                if (!thread.IsAlive)
                {
                    evt.EndTreath();
                    return;
                }
            }
        }
    }
}
 