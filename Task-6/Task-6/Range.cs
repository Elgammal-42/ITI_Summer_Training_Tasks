using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    internal class Range<T> where T : struct, IComparable<T>
    {
        public T Minimum { get; set; }
        public T Maximum { get; set; }
        public Range(T min, T max)
        {
            Minimum = min;
            Maximum = max;
        }

        public bool IsInRange(T value)
        {
            if (value.CompareTo(Minimum) >= 0 && value.CompareTo(Maximum) <= 0)
                return true;
            else return false;
        }

        public int Length()
        {
            dynamic min = Minimum;
            dynamic max = Maximum;
            return (int)(max - min);
        }


    }
}
