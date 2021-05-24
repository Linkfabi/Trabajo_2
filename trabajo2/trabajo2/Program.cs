using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Configuration;
using System.Threading.Tasks;
using trabajo2.Hilos;

namespace trabajo2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando hilo del Server");
            int puerto = Convert.ToInt32(ConfigurationManager.AppSettings["puerto"]);
            HiloServer hiloServer = new HiloServer(puerto);
            Thread t = new Thread(new ThreadStart(hiloServer.Ejecutar));
            t.Start();
        }
    }
}
