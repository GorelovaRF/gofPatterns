using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder2
{

    
    public class Vendedor      
    {

        protected int _idVend;
        protected string _nombreVend;

        public Vendedor (int idVend, string nombreVend)
        {
            this._idVend = idVend;
            this._nombreVend = nombreVend;
        }

        public BuilderDocumentacion Builder { get; set; }
        public void listaDoc()
        {
            Console.WriteLine("Id del vendedor : " + _idVend.ToString() + " , con el nombre: " + _nombreVend + " ha hecho siguientes solicitudes:");
            foreach(Documento d in Builder.listaSolMat)
            {
                
                
                Console.WriteLine("La solicitud de matriculacion: " + d.GetType().Name);

            }

            foreach(Documento d in Builder.listaSolPed)
            {
               
                Console.WriteLine( "La solicitid de pedido: " + d.GetType().Name);
            }

          
        }

        public void crearDocimento()
        {
            Builder.crearSolMat();
            Builder.crearSolPepido();
        }

    }
}