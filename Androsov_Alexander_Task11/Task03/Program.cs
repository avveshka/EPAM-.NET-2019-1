using NetBasicsDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] objArray = new object[10000];
            int count = 0;
            for (int i = -50; i < 50; i++)
            {
                for (int j = -50; j < 50; j++)
                {
                    objArray[count] = new TwoDPointWithHash(i, j);
                    count++;
                }
            }
            Dictionary<int, int> dict = new Dictionary<int, int>();
            foreach (TwoDPointWithHash item in objArray)
            {
                int hash = 0;
                hash = item.GetHashCode();
                if (dict.Keys.Contains(hash))
                {
                    dict[hash]++;
                }
                else
                {
                    dict.Add(hash, 1);
                }
            }
            Console.WriteLine($"Всего значений = {objArray.Length}");
            Console.WriteLine($"Уникальных значений = {dict.Keys.Count}");
            Console.ReadKey();
        }
    }
}
