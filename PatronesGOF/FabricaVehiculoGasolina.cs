using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatronesGOF
{
    public class FabricaVehiculoGasolina : FabricaVehiculo
    {
        public override Automovil crearAuto()
        {
            return new AutomovilGasolina();
        }

        public override Scooter crearScooter()
        {
            return new ScooterGasolina();
           
        }
    }
}