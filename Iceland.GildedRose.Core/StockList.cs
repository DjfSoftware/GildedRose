using Iceland.GildedRose.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iceland.GildedRose.Core
{
    public class StockList : List<Item>
    {
        public StockList()
        {
            Add(new Item("Aged brie", 1, 1, ItemType.Maturing));
            Add(new Item("Backstage pass #1", -1, 2, ItemType.BackstagePass));
            Add(new Item("Backstage pass #2", 9, 2, ItemType.BackstagePass));
            Add(new Item("Sulfuras", 2, 2, ItemType.Legendary));
            Add(new Item("Normal item #1", -1, 55, ItemType.Standard));
            Add(new Item("Normal item #2", 2, 2, ItemType.Standard));
            Add(new Item("Invalid item", 2, 2, ItemType.Invalid));
            Add(new Item("Conjured #1", 2, 2, ItemType.Conjured));
            Add(new Item("Conjured #2", -1, 5, ItemType.Conjured));
        }
    }
}
