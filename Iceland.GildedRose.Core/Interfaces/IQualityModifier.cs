namespace Iceland.GildedRose.Core
{
    public interface IQualityModifier
    {
        void ValidateQuality(Item item);
    }
}