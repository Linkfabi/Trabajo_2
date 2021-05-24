using System;
using Trabajo2Model.DTO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo2Model.DAL
{
    public interface IMedidorConsumoDAL
    {
        List<int> ObtenerMedidoresConsumo();
    }
}
