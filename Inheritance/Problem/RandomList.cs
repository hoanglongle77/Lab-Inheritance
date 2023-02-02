using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Problem
{
    internal class RandomList : List<string>
    {
        private Random rnd;

        public RandomList()
        {
        }

        public RandomList(Random rnd)
        {
            this.rnd=rnd;
        }

        public RandomList(IEnumerable<string> collection) : base(collection)
        {
        }

        public RandomList(int capacity) : base(capacity)
        {
        }

        public string RemoveRandomElement()
        {
            int index = rnd.Next(0, this.Count);
            string str = this[index];
            this.RemoveAt(index);
            return str;
        }

    }
}
