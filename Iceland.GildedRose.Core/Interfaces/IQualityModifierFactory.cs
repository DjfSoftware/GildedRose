using Iceland.GildedRose.Core.ItemQualityEngineFactory;

namespace Iceland.GildedRose.Core
{
    public interface IQualityModifierFactory
    {
        IQualityModifier CreateQualityModifier(ItemType itemType);
    }
}