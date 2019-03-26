using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassFigure
{
    public abstract class Figure
    {
        protected int centerX;
        protected int centerY;
        public abstract void Draw();

        public int X
        {
            protected set => centerX = value;
            get => centerX;
        }

        public int Y
        {
            protected set => centerY = value;
            get => centerY;
        }
    }
}
