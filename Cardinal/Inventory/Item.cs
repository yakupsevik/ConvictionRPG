using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum rarity { COMMON = 0, UNCOMMON, RARE, LEGENDARY, MYTHIC}
enum itemTypes { WEAPON = 0, ARMOR}

namespace ConvictionRPG
{
    abstract class Item
    {
        public Item()
        { }

        public Item(int itemType, int level, int rarity)
        {
            this.rarity = rarity;
            this.level = random.Next(1, (level+1));
            buyValue = this.level + this.rarity + this.level * this.rarity * 10;
            sellValue = buyValue / 2;
            this.itemType = itemType;
        }


        Random random = new Random();

        public string name { get; set; } = "EMPTY";
        public int level { get; set; } = 0;
        public int buyValue { get; set; } = 0;
        public int sellValue { get; set; } = 0;
        public int rarity { get; set; } = 0;
        public int itemType { get; set; } = -1;

        public virtual string toString() { return null; }
        public virtual string toStringSave() { return null; }

    }
}
