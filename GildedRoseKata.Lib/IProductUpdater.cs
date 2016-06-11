using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseKata.Lib
{
    public interface IProductUpdater
    {
        bool Match(Item item);

        bool Update(Item item);
    }
}
