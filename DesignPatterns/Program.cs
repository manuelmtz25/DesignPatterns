﻿using System;
using DesignPatterns.DependencyInjection;
using DesignPatterns.Factory;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Singleton

            //Utilizando singleton
            //var singleton = Singleton.Singleton.Instance;

            //Utilizando singleton para un log
            //var log = Singleton.Log.Instance;
            //log.Save("a");
            //log.Save("b");

            #endregion

            #region Factory

            //SaleFactory storeSaleFactory = new StoreSaleFactory(10);
            //ISale sale1 = storeSaleFactory.GetSale();
            //sale1.Sell(15);

            #endregion

            #region Dependency Injection

            var beer = new Beer("Pikantus", "Erdinger");
            var drinkWithBeer= new DrinkWithBeer(10, 1, beer);
            drinkWithBeer.Build();

            #endregion

        }
    }
}
