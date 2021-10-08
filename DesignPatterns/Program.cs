using System;
using System.Linq;
using DesignPatterns.Factory;
using DesignPatterns.Models;
using DesignPatterns.Repository;


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

            //var beer = new Beer("Pikantus", "Erdinger");
            //var drinkWithBeer= new DrinkWithBeer(10, 1, beer);
            //drinkWithBeer.Build();

            #endregion

            #region Repository

            //Sin usar el patrón repositorio
            //using (var context=new beerDBContext())
            //{
            //    var list = context.Beers.ToList();
            //    foreach (var beer in list)
            //    {
            //        Console.WriteLine(beer.Name);
            //    }
            //}

            //1 Repository Pattern
            //using (var context = new beerDBContext())
            //{
            //    var beerRepository=new BeerRepository(context);
            //    var beer=new Beer();
            //    beer.Name = "XX Lager";
            //    beer.Description = "Lager";
            //    beerRepository.Add(beer);
            //    beerRepository.Save();

            //    foreach (var itemBeer in beerRepository.Get())
            //    {
            //        Console.WriteLine(itemBeer.Name);
            //    }
            //}

            //2 Repository Pattern using Generics
            //using (var context = new beerDBContext())
            //{
            //    var beerRepository=new Repository<Beer>(context);
            //    var beer = new Beer() {Name = "Fuller", Description = "Strong Ale"};
            //    beerRepository.Add(beer);
            //    beerRepository.Save();

            //    foreach (var item in beerRepository.Get())
            //    {
            //        Console.WriteLine($"{item.Name} {item.Description}");
            //    }
            //}

            //3
            //using (var context = new beerDBContext())
            //{
            //    var brandRepository=new Repository<Brand>(context);

            //    var brand=new Brand(){Name = "Fuller"};
            //    brandRepository.Add(brand);
            //    brandRepository.Save();
            //    foreach (var item in brandRepository.Get())
            //    {
            //        Console.WriteLine(item.Name);
            //    }
                
            //}

            #endregion

        }
    }
}
