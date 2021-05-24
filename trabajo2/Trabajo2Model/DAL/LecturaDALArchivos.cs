using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabajo2Model.DTO;

namespace Trabajo2Model.DAL
{
    public class LecturaDALArchivos : ILecturaDAL
    {

        private string traficoTxt = Directory.GetCurrentDirectory()
            + Path.DirectorySeparatorChar + "Trafico.txt";

        private string consumoTxt = Directory.GetCurrentDirectory()
            + Path.DirectorySeparatorChar + "Consumo.txt";


        //Patron Singleton
        private LecturaDALArchivos()
        {

        }
        private static ILecturaDAL instancia;

        public static ILecturaDAL GetInstance()
        {
            if (instancia == null)
                instancia = new LecturaDALArchivos();
            return instancia;
        }



        public List<MedidorConsumo> ObtenerLecturasConsumo()
        {
            List<MedidorConsumo> lista = new List<MedidorConsumo>();
            try
            {
                using (StreamReader reader = new StreamReader(consumoTxt))
                {
                    string linea = null;
                    do
                    {
                        linea = reader.ReadLine();
                        if (linea != null)
                        {
                            string[] textoArray = linea.Split('|');
                            MedidorConsumo m = new MedidorConsumo()
                            {
                                Fecha = DateTime.Parse(textoArray[0]),
                                NroMedidor = Int32.Parse(textoArray[1]),
                                ConsumoActual = Int32.Parse(textoArray[2]),
                                NroSerie = Int32.Parse(textoArray[3]),
                                Estado = textoArray[4]
                            };
                            lista.Add(m);
                        }

                    } while (linea != null);
                }
            }
            catch (IOException ex)
            {
                lista = null;
            }
            return lista;
        }



        public List<MedidorTrafico> ObtenerLecturasTrafico()
        {
            List<MedidorTrafico> lista = new List<MedidorTrafico>();
            try
            {
                using (StreamReader reader = new StreamReader(traficoTxt))
                {
                    string linea = null;
                    do
                    {
                        linea = reader.ReadLine();
                        if (linea != null)
                        {
                            string[] textoArray = linea.Split('|');
                            MedidorTrafico m = new MedidorTrafico()
                            {
                                Fecha = DateTime.Parse(textoArray[0]),
                                NroMedidor = Int32.Parse(textoArray[1]),
                                CantVehiculo = Int32.Parse(textoArray[2]),
                                NroSerie = Int32.Parse(textoArray[3]),
                                Estado = textoArray[4]
                            };
                            lista.Add(m);
                        }

                    } while (linea != null);
                }
            }
            catch (IOException ex)
            {
                lista = null;
            }
            return lista;
        }



        public void RegistrarLecturaConsumo(MedidorConsumo m)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(consumoTxt, true))
                {                    
                    writer.WriteLine(JsonConvert.SerializeObject(m));
                    writer.Flush();
                }
            }
            catch (IOException ex)
            {

            }
        }


        public void RegistrarLecturaTrafico(MedidorTrafico m)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(traficoTxt, true))
                {                    
                    writer.WriteLine(JsonConvert.SerializeObject(m));
                    writer.Flush();
                }
            }
            catch (IOException ex)
            {

            }
        }

    }
}
