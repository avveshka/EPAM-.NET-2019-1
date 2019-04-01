using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task01;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new DynamicArray<string>(new List<string> { "qwe", "asd", "zxc", "rty", "fgh" });
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
