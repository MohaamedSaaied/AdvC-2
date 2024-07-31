using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvC_2
{
    internal class fl<T>
    {
        private readonly List<T> l;
        private readonly int size;

        public fl(int Size)
        {
            l = new List<T>(Size);
            size = Size;
        }

        public void Add(T item)
        {
            if (l.Count >= size) Console.WriteLine($"List is full current size {size}");
            l.Add(item);
        }

        public T Get(int index)
        {
            if(index>size) throw new IndexOutOfRangeException($"Invalid index number {index}");
            return l[index-1];
        }
    }
}
