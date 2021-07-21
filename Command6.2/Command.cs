using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command6._2
{
    public abstract class OrderCommand
    {
        public abstract void Execute(List<Coche> order, Coche newCoche);
    }
}
