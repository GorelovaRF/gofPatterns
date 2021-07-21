using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder2
{
    public abstract class BuilderDocumentacion
    {

        public IList<Documento> listaSolPed { get; set; }
        public IList<Documento> listaSolMat { get; set; }

        public BuilderDocumentacion()
        {
            listaSolPed = new List<Documento>();
            listaSolMat = new List<Documento>();
        }

        public abstract void crearSolMat(); 

        public abstract void crearSolPepido();
    }
}