using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge3
{
    public abstract class FormularioMatriculacion
    {
        protected Implementor _implementor;
        public Implementor Implementor
        {
            set { _implementor = value; }
            get { return _implementor; }
        }

        public abstract void crear(string nombreForm);

        public abstract void mostrar();
    }
}