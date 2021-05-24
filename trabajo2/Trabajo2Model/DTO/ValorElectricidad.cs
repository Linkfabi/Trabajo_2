using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo2Model.DTO
{
    public class ValorElectricidad
    {
        private int idElectricidad;
        private float tarifa;

        public int IdElectricidad { get => idElectricidad; set => idElectricidad = value; }
        public float Tarifa { get => tarifa; set => tarifa = value; }
    }
}
