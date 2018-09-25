using FluentAssertions;
using Iceland.GildedRose.Core;
using Iceland.GildedRose.Core.ItemQualityEngineFactory;
using NUnit.Framework;

namespace Iceland.GildedRose.Tests
{
    [TestFixture]
    public class StandardItemQualityModifierTests
    {
        [Test]
        public void ValidateQuality_GivenQualityGreaterThan50AndSlowDegradation_WhenQualityCalculated_ThenQualityIs50ThenReduced()
        {
            var item = new Item("test", 1, 55, ItemType.Standard);

            var instance = new StandardItemQualityModifier();
            instance.ValidateQuality(item);

            item.Quality.Should().Be(49);
        }

        [Test]
        public void ValidateQuality_GivenQualityGreaterThan50AndFastDegradation_WhenQualityCalculated_ThenQualityIs50ThenReduced()
        {
            var item = new Item("test", 0, 55, ItemType.Standard);

            var instance = new StandardItemQualityModifier();
            instance.ValidateQuality(item);

            item.Quality.Should().Be(48);
        }

        [Test]
        public void ValidateQuality_GivenQualityLessThan50AndSlowDegradation_WhenQualityCalculated_ThenQualityReducedBy1()
        {
            var item = new Item("test", 1, 48, ItemType.Standard);

            var instance = new StandardItemQualityModifier();
            instance.ValidateQuality(item);

            item.Quality.Should().Be(47);
        }

        [Test]
        public void ValidateQuality_GivenQualityLessThan50AndFastDegradation_WhenQualityCalculated_ThenQualityReducedBy2()
        {
            var item = new Item("test", 0, 48, ItemType.Standard);

            var instance = new StandardItemQualityModifier();
            instance.ValidateQuality(item);

            item.Quality.Should().Be(46);
        }
    }
}
