using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
    class Enemy : ItemOnField
    {
        public Enemy(string name)
        {
            ItemType = name;
        }
    }
}
