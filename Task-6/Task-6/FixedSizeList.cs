using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    internal class FixedSizeList<T>
    {
        private List<T> list;
        private int Capacity { get; set; }
        private int size = 0;
        public FixedSizeList(int cap)
        {
            Capacity = cap;
            list = new List<T>();
        }
        public void Add(T item)
        {
            if (size >= Capacity)
            {
                Console.WriteLine("You have exceeded the List Capacity!");
                return;
            }
            size++;
            list.Add(item);
        }
        public T Get(int index)
        {
            if (index < 0 || index >= list.Count)
            {
                throw new ArgumentOutOfRangeException();
            }
            return list[index - 1];
        }
    }
}
