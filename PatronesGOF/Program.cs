using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesGOF
{
    class Program
    {
        static void Main(string[] args)
        {
            Catalogo catalogo = new Catalogo();
            FabricaVehiculo fabricaElectr = new FabricaVehiculoElectr();
            FabricaVehiculo fabricaGasolina = new FabricaVehiculoGasolina();


            catalogo.CrearAuto(fabricaElectr);
            catalogo.CrearAuto(fabricaGasolina);

            catalogo.CrearScooter(fabricaGasolina);
            catalogo.CrearScooter(fabricaElectr);

            catalogo.ImprimirVehiculos();

            Console.ReadKey();
        }
    }
}
