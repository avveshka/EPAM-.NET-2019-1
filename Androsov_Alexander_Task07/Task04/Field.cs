using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
    class Field
    {
        private int _width;
        private int _heigth;
        private int _countCells;
        private FieldCell[] _cells;
        public Field(int width, int heigth)
        {
            _width = width;
            _heigth = heigth;
            _cells = new FieldCell[_countCells];
            for (int i = 0; i < _countCells; i++)
            {
                _cells[i] = new FieldCell(5, 5);
            }
        }
        public void Draw() { }
        public void Reset() { }
    }
}
