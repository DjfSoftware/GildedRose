using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iceland.GildedRose.Core.ItemQualityEngineFactory
{
    public abstract class QualityModifier : IQualityModifier
    {
        public virtual void ValidateQuality(Item item)
        {
            if (item.Quality > 50)
            {
                item.Quality = 50;
            }
        }

        protected void ApplyBasicModifiers(Item item)
        {
            item.SellIn = item.SellIn - 1;

            if (item.SellIn < 0)
            {
                // Quality degrades twice as fast per day expired
                item.Quality = item.Quality - 2;
            }
            else
            {
                item.Quality = item.Quality - 1;
            }
        }
    }
}
