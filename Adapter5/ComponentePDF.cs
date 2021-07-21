using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter5
{
    public class ComponentePDF
    {
        public int NombreMiembro
        {
            get => default;
            set
            {
            }
        }

        protected string contenido;
        protected int id;

        public void pdfFijaId(int id)
        {
            this.id = id;
        }
        public void pdfFijaContenido(string contenido)
        {
            this.contenido = contenido;
        }

        public void pdfPreparaVisualizacion()
        {
            Console.WriteLine("Preparacion de visualizacion PDF id: " + id);
        }

        public void pdfRefresca()
        {
            Console.WriteLine("Refrescando PDF id:" +
              id);
        }

        public void pdfFinalizaVisualizacion()
        {
            Console.WriteLine("Visualizacion PDF id: "+ id + "con el contenido: " + contenido);
        }

        public void pdfEnviaImpresora()
        {
            Console.WriteLine("Imprimiendo el contenido de PDF id: " + id + "con el contenido: " + contenido);
        }
    }
}