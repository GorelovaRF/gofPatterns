using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter5
{
    public interface Documento
    {
        string contenido { set; }
        int id { set; }
        void dibuja();
        void imprime();
    }
}