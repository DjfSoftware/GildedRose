using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Iceland.GildedRose.Core.Interfaces;

namespace Iceland.GildedRose.Core.ItemQualityEngineFactory
{
    public class BackstagePassQualityModifier : QualityModifier, IBackstagePassQualityModifier
    {
        public override void ValidateQuality(Item item)
        {
            base.ValidateQuality(item);

            item.SellIn = item.SellIn - 1;

            if (item.SellIn < 0)
            {
                item.Quality = 0;
                return;
            }

            if (item.Quality < 50 && item.SellIn < 6)
            {
                item.Quality = item.Quality + 3;
                return;
            }

            if (item.Quality < 50 && item.SellIn < 11)
            {
                item.Quality = item.Quality + 2;
                return;
            }

            item.Quality = item.Quality - 1;
        }
    }
}
