using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
    class Hero : ItemOnField
    {
        public Hero()
        {
            ItemType = "Hero";
        }
        public void MoveDown() { }
        public void MoveLeft() { }
        public void MoveRight() { }
        public void MoveUp() { }
    }
}
