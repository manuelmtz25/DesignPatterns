using System;
using DesignPatterns.Factory;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //Utilizando singleton
            //var singleton = Singleton.Singleton.Instance;

            //Utilizando singleton para un log
            //var log = Singleton.Log.Instance;
            //log.Save("a");
            //log.Save("b");

            SaleFactory storeSaleFactory=new StoreSaleFactory(10);
            ISale sale1 = storeSaleFactory.GetSale();
            sale1.Sell(15);


        }
    }
}
