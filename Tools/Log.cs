using System;
using System.IO;

namespace Tools
{
    public sealed class Log
    {
        private static Log _instance = null;
        private string _path;
        private static object _protect= new object();

        public static Log GetInstance(string path)
        {
            //Truco cuando se trabaja con hilos.
            //Puede pasar que dos hilos entren al mismo tiempo en este método GetInstance()
            //los dos hilos, al acceder al método, podrían pensar que la instancia es nula
            //y podrían crear dos instancias de forma simultanea.
            //Mientras un hilo esté tranajando con el atributo _protect, lock() lo protegerá para que nadie más trabaje con el.
            //Lo que va a suceder es que, mientras un hilo esté trabajando con _protect, el otro hilo va a estar en espera.
            lock (_protect)
            {
                if (_instance == null)
                {
                    _instance = new Log(path);
                }
            }

            return _instance;
        }

        private Log(string path)
        {
            _path = path;
        }

        public void Save(string message)
        {
            File.AppendAllText(_path, message + Environment.NewLine);
        }
    }
}
