using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iceland.GildedRose.Core.ItemQualityEngineFactory
{
    public class ConjuredItemQualityModifier : QualityModifier, IConjuredItemQualityModifier
    {
        public override void ValidateQuality(Item item)
        {
            base.ValidateQuality(item);

            item.SellIn = item.SellIn - 1;

            item.Quality = item.Quality - 2;
        }
    }
}
