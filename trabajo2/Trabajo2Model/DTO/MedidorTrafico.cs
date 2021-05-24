using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo2Model.DTO
{
    public class MedidorTrafico : Medidor
    {
        private int cantVehiculo;

        public int CantVehiculo { get => cantVehiculo; set => cantVehiculo = value; }

        public override string ToString()
        {
            return "{\n" +
                "   \"Fecha\": \"" + Fecha + "\" \n" +
                "   \"IdMedidor\": \"" + NroMedidor + "\" \n" +
                "   \"cantidad Vehiculos\": \"" + CantVehiculo + "\" \n" +
                "   \"numero Serie\": \"" + NroSerie + "\" \n" +
                "   \"estado\": \"" + Estado + "\"\n" +
                "   UPDATE \n" +
                "}";
        }

    }
}
