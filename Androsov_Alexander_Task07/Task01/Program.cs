using ClassCircle;
using ClassFigure;
using ClassLine;
using ClassRectangle;
using ClassRing;
using ClassRound;
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
            Figure[] fig = new Figure[] { new Line(1, 1, 10), new Circle(2, 2, 5), new Rectangle(5, 5), new Round(3, 3, 6), new Ring(4, 4, 8, 7) };
            for (int i = 0; i < fig.Length; i++)
            {
                if (fig[i] is Line)
                {
                    ((Line)fig[i]).Draw();
                }
                else if (fig[i] is Circle)
                {
                    ((Circle)fig[i]).Draw();
                }
                else if (fig[i] is Rectangle)
                {
                    ((Rectangle)fig[i]).Draw();
                }
                else if (fig[i] is Round)
                {
                    ((Round)fig[i]).Draw();
                }
                else if (fig[i] is Ring)
                {
                    ((Ring)fig[i]).Draw();
                }
            }
            Console.ReadKey();
        }
    }
}
