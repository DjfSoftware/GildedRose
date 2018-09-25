using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iceland.GildedRose.Core
{
    public class ItemQualityEngine : IItemQualityEngine
    {
        public StockList StockList { get; }
        private readonly IQualityModifierFactory _qualityModifierFactory;

        public ItemQualityEngine(IQualityModifierFactory qualityModifierFactory, StockList stockList)
        {
            _qualityModifierFactory = qualityModifierFactory;
            StockList = stockList;
        }

        public void RefreshStock()
        {
            foreach (var item in StockList)
            {
                var qualityModifier = _qualityModifierFactory.CreateQualityModifier(item.ItemType);
                qualityModifier.ValidateQuality(item);
            }
        }
    }












}
