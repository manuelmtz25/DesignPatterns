using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
	public class Log
    {
        private static readonly Log _instance = new Log();
        private string _path = "log.txt";

        public static Log Instance
        {
            get
            {
                return _instance;
            }
        }

        //Haciedo el constructor privado, se evitará crear más objetos de esta clase
        private Log() { }

        public void Save(string message)
        {
            File.AppendAllText(_path, message + Environment.NewLine);
        }
    }
}
