using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure
{
    internal class List<T>
    {
        private T[] items;
        private int count;

        public int Capacity { get { return items.Length; } }
        public int Count { get { return count; } }
    }
}
