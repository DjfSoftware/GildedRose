using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iceland.GildedRose.Core
{
    public class Item
    {
        public Item(string name, int sellIn, int quality, ItemType itemType)
        {
            Name = name;
            SellIn = sellIn;
            Quality = quality;
            ItemType = itemType;
        }

        public string Name { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }
        public ItemType ItemType { get; }

        public override string ToString()
        {
            return $"{Name} - Sellin {SellIn} -  Quality: {Quality}";
        }
    }
}
