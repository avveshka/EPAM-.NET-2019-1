using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
    class FieldCell
    {
        public bool IsFull;
        private ItemOnField _item;
        public FieldCell(int width, int heigth)
        {
            IsFull = false;
        }
        public ItemOnField Item { set; get; }
    }
}
