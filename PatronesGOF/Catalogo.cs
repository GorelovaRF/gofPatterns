using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatronesGOF
{
    public class Catalogo
    {
        IList<Automovil> listaAutomovil;
        IList<Scooter> listaScooter;


        public Catalogo()
        {
            listaAutomovil = new List<Automovil>();
            listaScooter = new List<Scooter>();
        }

         public void CrearAuto(FabricaVehiculo fabrica)
         {
                listaAutomovil.Add(fabrica.crearAuto());
         }

        public void CrearScooter(FabricaVehiculo fabrica)
        {
            listaScooter.Add(fabrica.crearScooter());
        }

        public void ImprimirVehiculos()
        {
            Console.WriteLine("Lista de Automoviles: ");

                foreach(Automovil auto in listaAutomovil)
            {
                Console.WriteLine("Automovil: " + auto.GetType().Name);
            }


            Console.WriteLine("Lista de Scooters: ");

            foreach (Scooter sc in listaScooter)
            {
                Console.WriteLine("Scooter: " + sc.GetType().Name);
            }


        }

    }
}