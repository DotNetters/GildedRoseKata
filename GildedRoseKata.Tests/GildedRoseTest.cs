using System;
using NUnit.Framework;
using System.Collections.Generic;
using GildedRoseKata.Lib;

namespace GildedRoseKata.Tests
{
	[TestFixture()]
	public class GildedRoseTest
	{
        const int SELLIN_POSITIVE = 10;
        const int SELLIN_STEP1 = 10;
        const int SELLIN_STEP2 = 5;
        const int POSITIVE_QUALITY = 14;
        private const string STANDARD_ITEM_NAME = "Standard item";

        [Test()]
		public void StandardItem_DecreaseQuality_At_End_Of_Day() {
            var item = new Item { Name = STANDARD_ITEM_NAME, SellIn = SELLIN_POSITIVE, Quality = 10 };

            IList<Item> Items = new List<Item> { item };
			GildedRose app = new GildedRose(Items);
			app.UpdateQuality();


			Assert.AreEqual(9, item.Quality);
		}

        [Test()]
        public void StandardItem_SellIn_Decrease()
        {
            var item = new Item { Name = STANDARD_ITEM_NAME, SellIn = 10, Quality = 10 };

            IList<Item> Items = new List<Item> { item };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();


            Assert.AreEqual(9, item.SellIn);
        }

        [Test()]
        public void StandardItem_Expired()
        {
            var item = new Item { Name = STANDARD_ITEM_NAME, SellIn = 0, Quality = 10 };

            IList<Item> Items = new List<Item> { item };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();


            Assert.AreEqual(8, item.Quality);
        }

        [Test()]
        public void StandardItem_NotNegative()
        {
            var item = new Item { Name = STANDARD_ITEM_NAME, SellIn = 10, Quality = 0 };

            IList<Item> Items = new List<Item> { item };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();


            Assert.AreEqual(0, item.Quality);
        }

        [Test()]
        public void AgedBrie_IncreaseQuality()
        {
            var item = new Item { Name = ProductNames.AgedBrie, SellIn = 10, Quality = 49 };

            IList<Item> Items = new List<Item> { item };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();


            Assert.AreEqual(GildedRose.MAX_QUALITY, item.Quality);
        }

        [Test()]
        public void AgedBrie_Negative_IncreaseQuality()
        {
            var item = new Item { Name = ProductNames.AgedBrie, SellIn = -1, Quality = 40 };

            IList<Item> Items = new List<Item> { item };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();

            Assert.AreEqual(-2, item.SellIn);
            Assert.AreEqual(42, item.Quality);
        }


        [Test()]
        public void AgedBrie_IncreaseQuality_Maximum()
        {
            var item = new Item { Name = ProductNames.AgedBrie, SellIn = 10, Quality = GildedRose.MAX_QUALITY };

            IList<Item> Items = new List<Item> { item };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();


            Assert.AreEqual(GildedRose.MAX_QUALITY, item.Quality);
        }

        [Test()]
        public void Sulfuras_FixedQuality()
        {
            var item = new Item { Name = ProductNames.Sulfuras, SellIn = 10, Quality = 13 };

            IList<Item> Items = new List<Item> { item };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();


            Assert.AreEqual(13, item.Quality);
        }


        [Test()]
        public void Sulfuras_NotSell()
        {
            var item = new Item { Name = ProductNames.Sulfuras, SellIn = 10, Quality = 13 };

            IList<Item> Items = new List<Item> { item };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();


            Assert.AreEqual(10, item.SellIn);
        }

        [Test()]
        public void Backstage_IncreaseQuality_Step1()
        {
            var item = new Item { Name = ProductNames.BackstagePasses, SellIn = SELLIN_STEP1, Quality = POSITIVE_QUALITY };

            IList<Item> Items = new List<Item> { item };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();


            Assert.AreEqual(POSITIVE_QUALITY + 2, item.Quality);
        }

        [Test()]
        public void Backstage_IncreaseQuality_Step2()
        {
            var item = new Item { Name = ProductNames.BackstagePasses, SellIn = SELLIN_STEP2, Quality = POSITIVE_QUALITY };

            IList<Item> Items = new List<Item> { item };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();


            Assert.AreEqual(POSITIVE_QUALITY + 3, item.Quality);
        }

        [Test()]
        public void Backstage_IncreaseQuality_Expired()
        {
            var item = new Item { Name = ProductNames.BackstagePasses, SellIn = 0, Quality = POSITIVE_QUALITY };

            IList<Item> Items = new List<Item> { item };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();


            Assert.AreEqual(0, item.Quality);
        }
    }
}

