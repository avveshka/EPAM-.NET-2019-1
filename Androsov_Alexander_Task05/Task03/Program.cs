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
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите вторую сторону треугольника: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Введите третью сторону треугольника: ");
            int c = int.Parse(Console.ReadLine());
            Triangle triangle = new Triangle(a,b,c);
            Console.WriteLine($"Периметр треугольника = {triangle.Perimeter()}. Площадь треугольника = {triangle.Square()}");
            Console.ReadKey();
        }
    }
}
