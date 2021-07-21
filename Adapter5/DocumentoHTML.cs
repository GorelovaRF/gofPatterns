using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter5
{
    public class DocumentoHTML : Documento
    {
        protected string _contenido;
        protected int _id;

        public int id
        {
            protected get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        public string contenido
        {
            protected get
            {
                return _contenido;
            }
            set
            {
                _contenido = value;
            }
        }

        public void dibuja()
        {
            Console.WriteLine("Dibujando el documento HTML id: " + id + " con el contenido:" +contenido);
        }

        public void imprime()
        {
            Console.WriteLine("Imprime el documento HTML id: " + id + " con el contenido:" + contenido);
        }

    }

}
