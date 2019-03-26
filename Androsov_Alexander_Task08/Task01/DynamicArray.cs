using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class DynamicArray<T>
    {
        private T[] _array;
        private int _length;

        public DynamicArray()
        {
            _array = new T[16];
            Length = 8;
        }

        public DynamicArray(int length)
        {
            _array = new T[length*2];
            Length = length;
        }

        public DynamicArray(T[] array)
        {
            _array = new T[array.Length*2];
            array.CopyTo(_array, 0);
            Length = array.Length;
        }

        public int Length
        {
            set
            {
                if (value > 0)
                {
                    _length = value;
                }
                else
                {
                    throw new Exception();
                }
            }
            get => _length;
        }

        public int Capacity => _array.Length;

        public void ChangeCapasity(int capacityover)
        {
            T[] tempArray = _array;
            _array = new T[tempArray.Length + capacityover];
            tempArray.CopyTo(_array, 0);
        }

        public void Add(T item)
        {
            Insert(item, Length);
        }

        public void AddRange(T[] item)
        {
            if ((item.Length + _length) > _array.Length)
            {
                ChangeCapasity(item.Length);
            }
            item.CopyTo(_array, _length);
            _length += item.Length;
        }

        public bool Remove(T item)
        {
            var i = 0;
            foreach (T itemOfArray in _array)
            {
                if (itemOfArray.Equals(item))
                {
                    Array.Copy(_array, i + 1, _array, i, _length - i);
                    _length--;
                    return true;
                }
                i++;
            }
            return false;
        }

        public void Insert(T item, int index)
        {
            if (index > Length || index < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (_length == (_array.Length - 1))
            {
                ChangeCapasity(_array.Length);
            }
            Array.Copy(_array, index, _array, index + 1, _length - index);
            _array[index] = item;
            _length++;
        }

        public T this[int index]
        {
            get
            {
                if (index > Length || index < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                return _array[index];
            }
            set
            {
                if (index > Length || index < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                _array[index] = value;
            }
        }

        public void Show()
        {
            Console.WriteLine("Массив: ");
            foreach (T item in _array)
            { 
                Console.Write($"{item}  ");
            }
            Console.WriteLine();
        }
    }
}
