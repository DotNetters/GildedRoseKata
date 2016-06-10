using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseKata.Lib
{
    public class GildedRose
    {
        public const int MAX_QUALITY = 50;
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            for (var i = 0; i < Items.Count; i++)
            {
                if (Items[i].Name != ProductNames.AgedBrie && Items[i].Name != ProductNames.BackstagePasses)
                {
                    if (Items[i].Quality > 0)
                    {
                        if (Items[i].Name != ProductNames.Sulfuras)
                        {
                            Items[i].Quality = Items[i].Quality - 1;
                        }
                    }
                }
                else
                {
                    if (Items[i].Quality < MAX_QUALITY)
                    {
                        Items[i].Quality = Items[i].Quality + 1;

                        if (Items[i].Name == ProductNames.BackstagePasses)
                        {
                            if (Items[i].SellIn < 11)
                            {
                                IncreaseQuality(i);
                            }

                            if (Items[i].SellIn < 6)
                            {
                                IncreaseQuality(i);
                            }
                        }
                    }
                }

                if (Items[i].Name != ProductNames.Sulfuras)
                {
                    Items[i].SellIn = Items[i].SellIn - 1;
                }

                if (Items[i].SellIn < 0)
                {
                    if (Items[i].Name != ProductNames.AgedBrie)
                    {
                        if (Items[i].Name != ProductNames.BackstagePasses)
                        {
                            if (Items[i].Quality > 0)
                            {
                                if (Items[i].Name != ProductNames.Sulfuras)
                                {
                                    Items[i].Quality = Items[i].Quality - 1;
                                }
                            }
                        }
                        else
                        {
                            Items[i].Quality = Items[i].Quality - Items[i].Quality;
                        }
                    }
                    else
                    {
                        IncreaseQuality(i);
                    }
                }
            }
        }

        private void IncreaseQuality(int i)
        {
            if (Items[i].Quality < MAX_QUALITY)
            {
                Items[i].Quality = Items[i].Quality + 1;
            }
        }
    }
}
