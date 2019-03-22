using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
    class Hero : ItemOnField,IMovable,IAtackble
    {
        public Hero()
        {
            ItemType = "Hero";
        }

        public void Atack() { }
        public void MoveDown() { }
        public void MoveLeft() { }
        public void MoveRight() { }
        public void MoveUp() { }
    }
}
