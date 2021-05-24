using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabajo2Model.DTO;

namespace Trabajo2Model.DAL
{
    public interface ILecturaDAL
    {
        void RegistrarLecturaConsumo(MedidorConsumo m);
        void RegistrarLecturaTrafico(MedidorTrafico m);
        List<MedidorTrafico> ObtenerLecturasTrafico();
        List<MedidorConsumo> ObtenerLecturasConsumo();
    }
}
