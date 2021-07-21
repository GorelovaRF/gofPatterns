using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder2
{
    public class BuilderHTML : BuilderDocumentacion
    {

        public BuilderHTML():base() { }
        public override void crearSolMat()
        {
            listaSolMat.Add(new SolMatriculaHTML());
        }

        public override void crearSolPepido()
        {
            listaSolPed.Add(new SolPepidoHTML());
        }
    }
}