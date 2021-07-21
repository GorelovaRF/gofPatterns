using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace State7
{
    public class Entregado : Estado
    {
        public Entregado(Pedido pedido) : base(pedido) { }
        public override void agregarProducto(Item item)
        {
           
        }

        public override void borrarProducto(Item item)
        {
            
        }

        public override void manejarEstado(Pedido pedido)
        {
            Console.WriteLine("El pedido esta entregado");
        }

        public override void Validad()
        {
            
        }
    }
}