using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command6._2
{
    public class Receiver
    {

        public List<Coche> coches { get; set; }
        public Receiver()
        {
            coches = new List<Coche>();
        }

        public void ExecuteCommand(OrderCommand command, Coche coche)
        {
            command.Execute(this.coches, coche);
        }

        public void ShowCurrentCoches()
        {
            foreach (var c in coches)
            {
                c.Display();
            }
            Console.WriteLine("-----------------------");
        }




    }
}
