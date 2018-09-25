using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Iceland.GildedRose.Core.Interfaces;

namespace Iceland.GildedRose.Core.ItemQualityEngineFactory
{
    public class LegendaryItemQualityModifier : QualityModifier, ILegendaryItemQualityModifier
    {
        public override void ValidateQuality(Item item)
        {
            base.ValidateQuality(item);

            // SPEC: "a legendary item, never has to be sold or decreases in Quality"
        }
    }
}
