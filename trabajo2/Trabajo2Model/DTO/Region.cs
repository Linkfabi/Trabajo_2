using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo2Model.DTO
{
    public class Region
    {
        private int nroRegion;
        private String nombreRegion;

        public string NombreRegion { get => nombreRegion; set => nombreRegion = value; }
        public int NroRegion { get => nroRegion; set => nroRegion = value; }
    }
}
