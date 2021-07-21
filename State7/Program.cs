using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State7
{
    class Program
    {
        static void Main(string[] args)
        {
            Pedido p = new Pedido();
            Item i1 = new Item("eyeshadows");
            p.agregarProducto(new Item("mascara"));
            p.agregarProducto(new Item("eyeliner"));
            p.agregarProducto(new Item("lipstick"));
            p.agregarProducto(i1);
            p.mostrar();
            Console.WriteLine("---------------------");
            p.Solicitar();
            p.agregarProducto(new Item("sephora mask"));
            p.borra(i1);
            p.mostrar();
            p.validacion();
            Console.WriteLine("---------------------");

            p.Solicitar();
            
            
            p.Solicitar();


            Console.ReadKey();

        }
    }
}
