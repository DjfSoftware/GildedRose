using System.Runtime.Remoting.Messaging;
using Iceland.GildedRose.Core;
using Iceland.GildedRose.Core.Interfaces;
using Iceland.GildedRose.Core.ItemQualityEngineFactory;
using Ninject.Modules;

namespace Iceland.GildedRose
{
    public class IocBindings : NinjectModule
    {
        public override void Load()
        {
            Bind<IQualityModifier>().To<QualityModifier>();

            Bind<IItemQualityEngine>().To<ItemQualityEngine>();

            Bind<IBackstagePassQualityModifier>().To<BackstagePassQualityModifier>();
            Bind<IConjuredItemQualityModifier>().To<ConjuredItemQualityModifier>();
            Bind<ILegendaryItemQualityModifier>().To<LegendaryItemQualityModifier>();
            Bind<IMaturingItemQualityModifier>().To<MaturingItemQualityModifier>();
            Bind<IQualityModifierFactory>().To<QualityModifierFactory>();
            Bind<IStandardItemQualityModifier>().To<StandardItemQualityModifier>();

            Bind<StockList>().ToMethod(x => new StockList());
        }
    }
}
