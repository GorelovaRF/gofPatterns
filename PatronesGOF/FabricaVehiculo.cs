using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatronesGOF
{
    public abstract class FabricaVehiculo
    {
        public abstract Automovil crearAuto();

        public abstract Scooter crearScooter();
    }
}