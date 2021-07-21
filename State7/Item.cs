using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State7
{
    public class Item
    {
        protected string nombre;

        public Item(string nombre)
        {
            this.nombre = nombre;
        }

        public void mostrarProducto()
        {
            Console.WriteLine("Item: " + nombre);
        }

    }
}
