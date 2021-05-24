
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo2Model.DAL
{
    public class MedidorConsumoDALFactory
    {
        public static IMedidorConsumoDAL CreateDAL()
        {
            return MedidorConsumoDALArchivos.GetInstance();
        }
    }
}
