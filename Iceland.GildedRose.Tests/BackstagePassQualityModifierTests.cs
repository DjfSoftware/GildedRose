using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Iceland.GildedRose.Core;
using Iceland.GildedRose.Core.ItemQualityEngineFactory;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace Iceland.GildedRose.Tests
{
    [TestFixture]
    public class BackstagePassQualityModifierTests
    {
        [Test]
        public void ValidateQuality_GivenGigHasBeenPerformed_WhenQualityCalculated_ThenQualityIsZero()
        {
            var item = new Item("test", 0, 5, ItemType.BackstagePass);


            var instance = new BackstagePassQualityModifier();
            instance.ValidateQuality(item);

            item.Quality.Should().Be(0);
            item.SellIn.Should().Be(-1);
        }

        [Test]
        public void ValidateQuality_GivenGigIsOver10DaysAway_WhenQualityCalculated_ThenQualityIsReducedByOne()
        {
            var item = new Item("test", 31, 5, ItemType.BackstagePass);


            var instance = new BackstagePassQualityModifier();
            instance.ValidateQuality(item);

            item.Quality.Should().Be(4);
            item.SellIn.Should().Be(30);
        }

        [Test]
        public void ValidateQuality_GivenGigIs5DaysOrLessAway_WhenQualityCalculated_ThenQualityIsIncreasedBy3()
        {
            var item = new Item("test", 5, 5, ItemType.BackstagePass);


            var instance = new BackstagePassQualityModifier();
            instance.ValidateQuality(item);

            item.Quality.Should().Be(8);
            item.SellIn.Should().Be(4);
        }

        [Test]
        public void ValidateQuality_GivenGigIs10DaysOrLessAway_WhenQualityCalculated_ThenQualityIsIncreasedBy2()
        {
            var item = new Item("test", 10, 5, ItemType.BackstagePass);


            var instance = new BackstagePassQualityModifier();
            instance.ValidateQuality(item);

            item.Quality.Should().Be(7);
            item.SellIn.Should().Be(9);
        }
    }
}
