using FluentAssertions;
using Iceland.GildedRose.Core;
using Iceland.GildedRose.Core.ItemQualityEngineFactory;
using NUnit.Framework;

namespace Iceland.GildedRose.Tests
{
    [TestFixture]
    public class LegendaryItemQualityModifierTests
    {
        [Test]
        public void ValidateQuality_GivenQualityGreaterThan50_WhenQualityCalculated_ThenQualityRemainsAt50()
        {
            var item = new Item("test", 1, 55, ItemType.Legendary);

            var instance = new LegendaryItemQualityModifier();
            instance.ValidateQuality(item);

            item.Quality.Should().Be(50);
            item.SellIn.Should().Be(1);
        }


        [Test]
        public void ValidateQuality_GivenQualityLessThan50AndSlowDegradation_WhenQualityCalculated_ThenQualityReducedBy1()
        {
            var item = new Item("test", 1, 15, ItemType.Maturing);

            var instance = new LegendaryItemQualityModifier();
            instance.ValidateQuality(item);

            item.Quality.Should().Be(15);
            item.SellIn.Should().Be(1);
        }
    }
}
