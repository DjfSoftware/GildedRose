using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iceland.GildedRose.Core.ItemQualityEngineFactory
{
    public class StandardItemQualityModifier : QualityModifier, IStandardItemQualityModifier
    {
        public override void ValidateQuality(Item item)
        {
            base.ValidateQuality(item);

            ApplyBasicModifiers(item);
        }
    }
}
