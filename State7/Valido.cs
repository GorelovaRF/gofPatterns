using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace State7
{
    public class Valido : Estado
    {

        public Valido(Pedido pedido) : base(pedido) { }

        public override void agregarProducto(Item item)
        {
            Console.WriteLine("En el estado de validacion no se puede agregar productos");
        }


        public override void borrarProducto(Item item)
        {
            pedido.Items.Remove(item);
        }

        public override void manejarEstado(Pedido pedido)
        {
            pedido.Estado = new Entregado(pedido);
        }

        public override void Validad()
        {
            Console.WriteLine("El pedido esta validado por el cliente");

        }


    }
}