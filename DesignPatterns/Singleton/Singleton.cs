using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
	public class Singleton
    {
        private static readonly Singleton _instance = new Singleton();

        public static Singleton Instance
        {
            get
            {
                return _instance;
            }
        }

        //Haciedo el constructor privado, se evitará crear más objetos de esta clase
        private Singleton() { }
    }
}
