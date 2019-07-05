using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper.Configuration;

namespace FinestraArticoli.Model
{
    public class OrdineArticoloMap : ClassMap<OrdineArticolo>
    {
        public OrdineArticoloMap()
        {
            AutoMap();

            Map(a => a.Quantity).Ignore();

            //Map(a => a.OutOfStock).Ignore();
            //Map(a => a.StockRunningOut).Ignore();
        }
    }
}
