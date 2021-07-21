using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge3
{
    public class FormEspana : FormularioMatriculacion
    {
        protected string pais;

        public FormEspana (string pais) : base()
        {
            this.pais = pais;
        }

        public override void crear(string nombreForm)
        {
            _implementor.create(nombreForm);
        }

        public override void mostrar()
        {
            Console.WriteLine("Formilarios de: " + pais);
            _implementor.show();
        }
    }
}