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
            DynamicArray<string> da = new DynamicArray<string>(new string[] { "qwe", "rty", "uio", "asd", "fgh", "jkl" });
            Console.WriteLine($"Длинна массива = {da.Length}");
            da.Show();
            da.Add("qwe");
            da.Show();
            da.AddRange(new string[] { "qwe", "123", "tyu" });
            da.Show();
            da.Remove("qwe");
            da.Show();
            da.Insert("asd", 4);
            da.Show();
            Console.WriteLine($"Второй элемент массива - {da[1]}");
            Console.ReadKey();
        }
    }
}
