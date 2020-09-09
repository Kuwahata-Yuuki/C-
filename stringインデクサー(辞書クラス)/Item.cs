using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    internal　class Item
    {

        public String Key;
        public String value;
        public Item next;

        public Item(string Key,string value, Item next)
        {
            this.Key = Key;
            this.value = value;
            this.next = next;
        }

    }


}
