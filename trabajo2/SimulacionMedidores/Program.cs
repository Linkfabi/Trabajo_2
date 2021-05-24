using SocketsUtils;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacionMedidores
{
    class Program
    {
        public static void Main(string[] args)
        {

            /*string fecha;
            string id;
            string nroMedidor;
            string valor;
            string tipo;
            string estado = null;*/            


            string ip = ConfigurationManager.AppSettings["ip"];
            int puerto = Convert.ToInt32(ConfigurationManager.AppSettings["puerto"]);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Iniciando conexion a servidor {0} en el puerto {1}", ip, puerto);
            ClienteSocket clienteSocket = new ClienteSocket(puerto, ip);

           /* Console.WriteLine("Ingrese Fecha:  (yyyy-MM-dd-hh-mm-ss)");
            fecha = Console.ReadLine().ToLower().Trim();
            Console.WriteLine("Ingrese numero Medidor");
            nroMedidor = Console.ReadLine().ToLower().Trim();
            Console.WriteLine("Ingrese Tipo Medidor    (trafico o consumo)");
            tipo = Console.ReadLine().ToLower().Trim();
            Console.WriteLine("Ingrese Numero de Serie");
            id = Console.ReadLine().ToLower().Trim();
            Console.WriteLine("Ingrese Valor");
            valor = Console.ReadLine().ToLower().Trim();
            Console.WriteLine("Ingrese estado");
            estado = Console.ReadLine().ToLower().Trim();*/

            if (clienteSocket.Conectar())
            {
                string mensaje = null;
                mensaje = clienteSocket.Leer();
                Console.WriteLine(mensaje);
                clienteSocket.Escribir(Console.ReadLine().Trim());
                mensaje = clienteSocket.Leer();
                if(mensaje != "")
                {
                    Console.WriteLine(mensaje);
                }                
                mensaje = clienteSocket.Leer();
                if (mensaje != "")
                {
                    Console.WriteLine(mensaje);
                    clienteSocket.Escribir(Console.ReadLine().Trim());
                }
                
                mensaje = clienteSocket.Leer();
                if (mensaje != "")
                {
                    Console.WriteLine(mensaje);
                }

                Console.WriteLine("Presione una tecla para terminar la secion");
                Console.ReadKey();

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error al conectar al servidor");
            }
        }
    }
}
