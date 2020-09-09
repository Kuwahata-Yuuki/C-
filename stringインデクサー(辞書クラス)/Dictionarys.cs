using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    class Dictionarys
    {

        Item head;
        
        public Dictionarys()
        {
            this.head = new Item(null, null, null);
        }

        public string this[string key]
        {
            set
            {
                for(Item item = this.head.next;
                    item != null; item = item.next)
                    if(item.Key == key)
                    {
                        item.value = value;
                        return;
                    }
                this.head.next =
                    new Item(key, value, this.head.next);
            }
            get
            {
                for (Item item = this.head.next;
                    item != null; item = item.next)
                    if (item.Key == key)
                        return item.value;
                return null;
            }
        }

    }
}
