using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper.Configuration;

namespace FinestraArticoli.Model
{
    public class ArticoloMap : ClassMap<Articolo>
    {
        public ArticoloMap()
        {
            AutoMap();

            Map(a => a.OutOfStock).Ignore();
            Map(a => a.StockRunningOut).Ignore();
        }
    }
}
