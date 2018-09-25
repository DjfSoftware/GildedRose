using System;
using Iceland.GildedRose.Core.Interfaces;

namespace Iceland.GildedRose.Core.ItemQualityEngineFactory
{
    public class QualityModifierFactory : IQualityModifierFactory
    {
        private readonly IStandardItemQualityModifier _standard;
        private readonly IBackstagePassQualityModifier _backstage;
        private readonly ILegendaryItemQualityModifier _legendary;
        private readonly IMaturingItemQualityModifier _maturing;
        private readonly IConjuredItemQualityModifier _conjured;

        public QualityModifierFactory(IStandardItemQualityModifier standard, IBackstagePassQualityModifier backstage,
            ILegendaryItemQualityModifier legendary, IMaturingItemQualityModifier maturing,
            IConjuredItemQualityModifier conjured)
        {
            _conjured = conjured;
            _maturing = maturing;
            _legendary = legendary;
            _backstage = backstage;
            _standard = standard;
        }

        public IQualityModifier CreateQualityModifier(ItemType itemType)
        {
            switch (itemType)
            {
                case ItemType.Standard:
                case ItemType.Invalid:
                    return _standard;
                case ItemType.Maturing:
                    return _maturing;
                case ItemType.Legendary:
                    return _legendary;
                case ItemType.BackstagePass:
                    return _backstage;
                case ItemType.Conjured:
                    return _conjured;
                default:
                    throw new InvalidOperationException("Unsupported Item Type");

            }
        }
    }
}
