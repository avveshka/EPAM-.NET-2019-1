using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class MyNode<T>
    {
        public T _item;
        public MyNode<T> next;

        public MyNode(T item)
        {
            _item = item;
        }
    }
}
