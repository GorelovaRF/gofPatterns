using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace State7
{
    public class EnCurso : Estado
    {
        

        public EnCurso(Pedido pedido) : base(pedido) { }
        
        public override void agregarProducto(Item item)
        {
            pedido.Items.Add(item);
        }

        

        public override void borrarProducto(Item item)
        {
            pedido.Items.Remove(item);
               
        }

        public override void manejarEstado(Pedido pedido)
        {
            pedido.Estado = new Valido(pedido); 
        }

        public override void Validad()
        {
            
        }
    }
}