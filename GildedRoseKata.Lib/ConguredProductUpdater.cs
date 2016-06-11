using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseKata.Lib
{
    public class ConguredProductUpdater : IProductUpdater
    {
        public bool Match(Item item)
        {
            return item != null && item.Name == GildedRoseProducts.Congured;
        }

        public bool Update(Item item)
        {
            if (!Match(item))
            {
                return false;
            }

            item.SellIn--;

            if (item.SellIn >= 0)
            {
                item.Quality = item.Quality - 2;
            }
            else
            {
                item.Quality = item.Quality - 4;
            }

            if (item.Quality < 0)
            {
                item.Quality = 0;
            }
            return true;

        }
    }
}
