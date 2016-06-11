using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseKata.Lib
{
    public interface IProductUpdater
    {
        bool IsMatch(Item item);

        bool Update(Item item);
    }
}
