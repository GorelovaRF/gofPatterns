using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge3
{
    public class FormWPF : Implementor
    {
        private IList<string> _formilarios = new List<string>();
        public FormWPF()
        {
            _formilarios.Add("formilario 1 WPF");
            _formilarios.Add("formilario 2 WPF");
            _formilarios.Add("formilario 3 WPF");
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