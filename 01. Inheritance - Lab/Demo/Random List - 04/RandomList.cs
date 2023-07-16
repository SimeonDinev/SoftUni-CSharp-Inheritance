using System;
using System.Collections.Generic;
using System.Text;

namespace CustomRandomList
{
    public class RandomList : List<string>
    {

        public string RandomString()
        {
            Random random = new Random();
            int r = random.Next(0, this.Count);
            string removedItem = this[r];
            this.RemoveAt(r);
            return removedItem;
        }
    }
}
