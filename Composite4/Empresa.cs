using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite4
{
    public abstract class Empresa
    {

        protected string _nombreEmpresa;
        protected int numCoche;
        public Empresa(string nombreEmpresa)
        {
            this._nombreEmpresa = nombreEmpresa;
           
        }

        public abstract void AddFilial(Empresa filial);

        public abstract void MostrarInformacion();

        public abstract void Display(int indent);

        public void AnadirCoche()
        {
            numCoche = numCoche + 1;
        }
    }
}