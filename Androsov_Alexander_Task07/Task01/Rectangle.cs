using ClassFigure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRectangle
{
    public class Rectangle : Figure
    {
        private int _width;
        private int _heigth;
        public Rectangle(int width, int heigth)
        {
            Width = width;
            Heigth = heigth;
        }
        public int Width
        {
            set
            {
                if (value > 0)
                {
                    _width = value;
                }
                else
                {
                    throw new Exception("Ширина должна быть больше нуля");
                }
            }
            get
            {
                return _width;
            }
        }
        public int Heigth
        {
            set
            {
                if (value > 0)
                {
                    _heigth = value;
                }
                else
                {
                    throw new Exception("Высота должна быть больше нуля");
                }
            }
            get
            {
                return _heigth;
            }
        }
        public int GetArea()
        {
            return _width * _heigth;
        }
        public override void Draw()
        {
            Console.WriteLine($"Квадрат со сторонами {Width} и {Heigth} и площадью {GetArea()}");
        }
    }
}
