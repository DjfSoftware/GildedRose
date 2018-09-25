using Iceland.GildedRose.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Iceland.GildedRose.Core.ItemQualityEngineFactory;
using Ninject;

namespace Iceland.GildedRose
{
    class Program
    {
        static void Main(string[] args)
        {

            var kernel = new StandardKernel();
            kernel.Load<IocBindings>();

            var engine = kernel.Get<IItemQualityEngine>();

            // Run one days stock adjustment
            engine.RefreshStock();

            engine.StockList.ForEach(x => Console.WriteLine(x.ToString()));

            Console.Read();
        }
    }
}
