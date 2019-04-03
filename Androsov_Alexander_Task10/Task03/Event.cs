using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    public class Event
    {
        private event OnEndSort OnEndSort;

        public Event()
        {
            OnEndSort += SortEnded;
        }

        public void EndTreath()
        {
            OnEndSort?.Invoke();
        }

        private static void SortEnded()
        {
            Console.WriteLine("Сортировка окончена");
        }
    }
}
