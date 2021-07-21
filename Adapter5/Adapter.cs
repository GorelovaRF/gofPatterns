using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter5
{
    public class Adapter : Documento
    {
        protected ComponentePDF herramientaPdf = new ComponentePDF();

        public string contenido
        {
            set
            {
                herramientaPdf.pdfFijaContenido(value);
            }
        }

        public int id
        {
            set
            {
                herramientaPdf.pdfFijaId(value);
            }
        }

        public ComponentePDF ComponentePDF
        {
            get => default;
            set
            {
            }
        }

        public void dibuja()
        {
            herramientaPdf.pdfPreparaVisualizacion();
            herramientaPdf.pdfRefresca();
            herramientaPdf.pdfFinalizaVisualizacion();
        }

        public void imprime()
        {
            herramientaPdf.pdfEnviaImpresora();
        }
    }
}