using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    //Creator
    public abstract class SaleFactory
    {
        public abstract ISale GetSale();
    }

    //Concrete Creator
    public class StoreSaleFactory : SaleFactory
    {
        private decimal _extra;

        public StoreSaleFactory(decimal extra)
        {
            _extra = extra;
        }

        public override ISale GetSale()
        {
            return new StoreSate(_extra);
        }
    }

    //Concrete Product
    public class StoreSate : ISale
    {
        private decimal _extra;

        public StoreSate(decimal extra)
        {
            _extra = extra;
        }

        public void Sell(decimal total)
        {
            Console.WriteLine($"La venta en TIENDA tiene un total {total + _extra}");
        }
    }

    //Product
    public interface ISale
    {
        public void Sell(decimal total);
    }
}
