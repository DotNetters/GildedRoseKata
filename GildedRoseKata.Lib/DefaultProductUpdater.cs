using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseKata.Lib
{
    public class DefaultProductUpdater : IProductUpdater
    {
        public bool IsMatch(Item item)
        {
            return true;
        }

        public bool Update(Item item)
        {
            if (!IsMatch(item))
            {
                return false;
            }

            item.SellIn--;

            if (item.SellIn >= 0)
            {
                item.Quality = item.Quality - 1;
            }
            else
            {
                item.Quality = item.Quality - 2;
            }

            if (item.Quality < 0)
            {
                item.Quality = 0;
            }
            return true;
        }
    }
}
