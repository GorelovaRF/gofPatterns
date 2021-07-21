using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatronesGOF
{
    public class FabricaVehiculoElectr : FabricaVehiculo
    {
        public override Automovil crearAuto()
        {
            return new AutomovilElectrico();
        }

        public override Scooter crearScooter()
        {
            return new ScooterElectrico();
        }
    }
}