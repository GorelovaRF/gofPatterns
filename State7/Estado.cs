using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace State7
{
    public abstract class Estado
    {
        protected Pedido pedido;

        protected Estado(Pedido pedido)
        {
            this.pedido = pedido;
        }

        public abstract void manejarEstado(Pedido pedido);
        public abstract void agregarProducto(Item item);
        public abstract void borrarProducto(Item item);
        public abstract void Validad(); 




    }
}