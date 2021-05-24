using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabajo2Model.DTO;

namespace Trabajo2Model.DAL
{
    public class MedidorConsumoDALArchivos : IMedidorConsumoDAL
    {
        

        public static List<int> listMedidoresConsumo = new List<int>()
        {
            1,2,3,4,5,6,7,8,9,10
        };



        //Patron Singleton
        private MedidorConsumoDALArchivos()
        {

        }
        private static IMedidorConsumoDAL instancia;

        public static IMedidorConsumoDAL GetInstance()
        {
            if (instancia == null)
                instancia = new MedidorConsumoDALArchivos();
            return instancia;
        }


        public List<int> ObtenerMedidoresConsumo()
        {
            return listMedidoresConsumo;
        }
    }
}
