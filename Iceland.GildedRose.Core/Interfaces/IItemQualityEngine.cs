namespace Iceland.GildedRose.Core
{
    public interface IItemQualityEngine
    {
        StockList StockList { get; }

        void RefreshStock();
    }
}