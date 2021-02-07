using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvictionRPG
{
    class Inventory
    {
        public List<Item> itemArr = new List<Item>();

        private void initialize(int from)
        {
            List<Item> itemArr = new List<Item>();
        }

        public void addItem(Item item)
        {
            itemArr.Add(item);
        }

        public void removeItem(int index)
        {
            itemArr.RemoveAt(index);
        }

        public int size()
        {
            return itemArr.Count;
        }

        public Item this[int index]
        {
            get
            {
                return itemArr[index];
            }
        }
    }
}
