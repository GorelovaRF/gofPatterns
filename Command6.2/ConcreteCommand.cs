using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command6._2
{
    class ConcreteCommand 
    {
        /// <summary>
        /// A concrete command
        /// </summary>
        public class AddCommand : OrderCommand
        {
            public override void Execute(List<Coche> currentCoche, Coche newCoche)
            {
                currentCoche.Add(newCoche);
            }
        }

        /// <summary>
        /// A concrete command
        /// </summary>
        public class RemoveCommand : OrderCommand
        {
            public override void Execute(List<Coche> currentCoche, Coche newCoche)
            {
                currentCoche.Remove(currentCoche.Where(x => x.Name == newCoche.Name).First());
            }
        }

        /// <summary>
        /// A concrete command
        /// </summary>
        public class ModifyCommand : OrderCommand
        {
            public override void Execute(List<Coche> currentCoche, Coche newCoche)
            {
                var item = currentCoche.Where(x => x.Name == newCoche.Name).First();
                item.Price = newCoche.Price;
                item.Discout = newCoche.Discout;


              
            }
        }
    }
}
