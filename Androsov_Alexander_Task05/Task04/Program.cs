using ClassMyString;
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
            Console.Write("Введите первую строку : ");
            MyString mystring1 = new MyString(Console.ReadLine());
            Console.Write("Введите вторую строку : ");
            MyString mystring2 = new MyString(Console.ReadLine());
            if(mystring1 == mystring2)
            {
                Console.WriteLine("Строки равны");
            }
            else
            {
                Console.WriteLine("Строки не равны");
            }
            mystring1 = mystring1 + mystring2;
            string outputstring = mystring1.ToString();
            Console.WriteLine($"Сложенная строка - {outputstring}");
            mystring1 = mystring1 - mystring2;
            outputstring = mystring1.ToString();
            Console.WriteLine($"Вычтенная строка - {outputstring}");
            Console.ReadKey();
        }
    }
}
