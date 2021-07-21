using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder2
{
    public class BuilderPDF : BuilderDocumentacion
    {
        public BuilderPDF() : base() { }
        public override void crearSolMat()
        {
            listaSolMat.Add(new SolMatriculaPDF());
        }

        public override void crearSolPepido()
        {
            listaSolPed.Add(new SolPepidoPDF());
        }
    }
}