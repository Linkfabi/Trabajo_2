using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo2Model.DAL
{
    public class MedidorTraficoDALArchivos :IMedidorTraficoDAL
    {
        public static List<int> listMedidoresTrafico = new List<int>()
        {
            21,22,23,24,25,26,27,28,29,30
        };



        //Patron Singleton
        private MedidorTraficoDALArchivos()
        {

        }
        private static IMedidorTraficoDAL instancia;

        public static IMedidorTraficoDAL GetInstance()
        {
            if (instancia == null)
                instancia = new MedidorTraficoDALArchivos();
            return instancia;
        }


        public List<int> ObtenerMedidoresTrafico()
        {
            return listMedidoresTrafico;
        }
    }
}
