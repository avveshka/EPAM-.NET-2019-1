using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
    class Enemy : ItemOnField,IMovable,IAtackble
    {
        public Enemy(string name)
        {
            ItemType = name;
        }
        public void MoveDown() { }
        public void MoveLeft() { }
        public void MoveRight() { }
        public void MoveUp() { }
        public void Atack() { }
    }
}
