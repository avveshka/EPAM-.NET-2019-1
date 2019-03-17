using ClassTriangle;
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
            Console.Write("Введите первую сторону треугольника: ");
            string a = Console.ReadLine();
            Console.Write("Введите вторую сторону треугольника: ");
            string b = Console.ReadLine();
            Console.Write("Введите третью сторону треугольника: ");
            string c = Console.ReadLine();
            Triangle triangle = new Triangle(a,b,c);
            Console.WriteLine($"Периметр треугольника = {triangle.Perimeter()}. Площадь треугольника = {triangle.Square()}");
            Console.ReadKey();
        }
    }
}
