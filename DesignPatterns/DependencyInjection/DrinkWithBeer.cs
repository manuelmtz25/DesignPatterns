using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DependencyInjection
{
    public class DrinkWithBeer
    {
        //Antes
        //Al realizar la inyección de dependencias lo que se debe de hacer es quitar la inicialización de este lugar e iyectarla directamente sobre el constructor
        //private Beer _beer = new Beer("Pikantus", "Erdinger");
        private Beer _beer;
        private decimal _water;
        private decimal _sugar;

        //Antes
        //public DrinkWithBeer(decimal water, decimal sugar)
        public DrinkWithBeer(decimal water, decimal sugar, Beer beer)
        {
            _water = water;
            _sugar = sugar;
            _beer = beer;
        }

        public void Build()
        {
            Console.WriteLine($"Preparamos bebida que tiene agua {_water}, azúcar {_sugar} y cerveza {_beer.Name}");
        }

    }
}
