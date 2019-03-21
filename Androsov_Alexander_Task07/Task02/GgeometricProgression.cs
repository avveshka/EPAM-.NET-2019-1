using DemoApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassGgeometricProgression
{
    public class GgeometricProgression : ISeries, IIndexable
    {
        private double _first;
        private double _step;
        private int _currentIndex;
        public GgeometricProgression(double first, double step)
        {
            _first = first;
            _step = step;
            _currentIndex = 1;
        }

        public double GetCurrent()
        {
            return _first * Math.Pow(_step, _currentIndex - 1);
        }

        public bool MoveNext()
        {
            _currentIndex++;
            return true;
        }

        public void Reset()
        {
            _currentIndex = 1;
        }

        public double this[int index]
        {
            get
            {
                return _first * Math.Pow(_step, index - 1);
            }
        }
    }
}
