using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace State7
{
    public class Pedido
    {
        protected IList<Item> items = new List<Item>();
       protected Estado estado;

        public IList<Item> Items
        {
            get
            {
                return items;
            }
        }

        public Pedido()
        {
            estado = new EnCurso(this);
        }
        public Estado Estado
        {
            get { return estado; }
            set
            {
                estado = value;
                Console.WriteLine("Estado: " + estado.GetType().Name);
            }
        }
        public void Solicitar()
        {
            estado.manejarEstado(this);
        }
            
        public void mostrar()
        {
            Console.WriteLine("Lista de items: ");
            foreach(Item i in items)
            {
                i.mostrarProducto();

            }
        }
        public void borra(Item item)
        {
            estado.borrarProducto(item);
        }

        public void agregarProducto(Item item)
        {
            estado.agregarProducto(item);
        }
        public void validacion()
        {
            estado.Validad();
        }
     }
}