using FluentAssertions;
using Iceland.GildedRose.Core;
using Iceland.GildedRose.Core.ItemQualityEngineFactory;
using NUnit.Framework;

namespace Iceland.GildedRose.Tests
{
    [TestFixture]
    public class MaturingItemQualityModifierTests
    {
        [Test]
        public void ValidateQuality_GivenQualityGreaterThan50_WhenQualityCalculated_ThenQualityRemainsAt50()
        {
            var item = new Item("test", 1, 55, ItemType.Maturing);

            var instance = new MaturingItemQualityModifier();
            instance.ValidateQuality(item);

            item.Quality.Should().Be(50);
            item.SellIn.Should().Be(0);
        }


        [Test]
        public void ValidateQuality_GivenQualityLessThan50AndSlowDegradation_WhenQualityCalculated_ThenQualityReducedBy1()
        {
            var item = new Item("test", 1, 13, ItemType.Maturing);

            var instance = new MaturingItemQualityModifier();
            instance.ValidateQuality(item);

            item.Quality.Should().Be(14);
            item.SellIn.Should().Be(0);
        }
    }
}
