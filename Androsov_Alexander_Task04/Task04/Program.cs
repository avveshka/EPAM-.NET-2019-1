using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "";
            int N = 1000;
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            for (int i = 0; i < N; i++)
            {
                str += "*";
            }
            stopWatch.Stop();
            Console.WriteLine($"Добавление {N} звёзд в string заняло = {stopWatch.Elapsed}");
            StringBuilder sb = new StringBuilder();
            stopWatch.Reset();
            stopWatch.Start();
            for (int i = 0; i < N; i++)
            {
                sb.Append("*");
            }
            stopWatch.Stop();
            Console.WriteLine($"Добавление {N} звёзд в stringbuilder заняло = {stopWatch.Elapsed}");
            Console.ReadKey();
        }
    }
}
