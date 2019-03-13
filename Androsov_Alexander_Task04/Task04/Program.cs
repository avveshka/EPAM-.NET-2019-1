using System;
using System.Collections.Generic;
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
            StringBuilder sb = new StringBuilder();
            int N = 50000;
            DateTime time = new DateTime();
            DateTime time1 = new DateTime();
            time = DateTime.Now;
            for (int i = 0; i < N; i++)
            {
                str += "*";
            }
            time1 = DateTime.Now;
            Console.WriteLine($"Добавление {N} звёзд в string заняло = {time1.Subtract(time)}");
            time = DateTime.Now;
            for (int i = 0; i < N; i++)
            {
                sb.Append("*");
            }
            time1 = DateTime.Now;
            Console.WriteLine($"Добавление {N} звёзд в stringbuilder заняло = {time1.Subtract(time)}");
            Console.ReadKey();
        }
    }
}
