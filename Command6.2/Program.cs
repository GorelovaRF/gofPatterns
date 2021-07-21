using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoker invoker = new Invoker();
            invoker.SetCommand(1);
            invoker.SetCoche(new Coche("Toyota Yaris", 8000,"no hay discuento"));
            invoker.ExecuteCommand();

            invoker.SetCommand(1);
            invoker.SetCoche(new Coche("Mazda 3", 11000, "no hay discuento"));
            invoker.ExecuteCommand();


            invoker.ShowCurrentOrder();

            invoker.SetCommand(2);
            invoker.SetCoche(new Coche("Toyota Yaris", 6900, "discuento 13%"));
            invoker.ExecuteCommand();
            invoker.ShowCurrentOrder();



            Console.ReadKey();


        }
    }
}
