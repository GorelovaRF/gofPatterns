using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge3
{
    public class FormHTML : Implementor
    {
        private IList<string> _formilarios = new List<string>();

        public FormHTML()
        {
            _formilarios.Add("formilario 1 HTML");
            _formilarios.Add("formilario 2 HTML");
            _formilarios.Add("formilario 3 HTML");
        }
        public override void create(string nombreForm)
        {
            _formilarios.Add(nombreForm);
        }



        public override void show()
        {
           foreach (string f in _formilarios)
            {
                Console.WriteLine(f);
            }
        }


    }
}