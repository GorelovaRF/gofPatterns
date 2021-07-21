using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite4
{
    public class EmpresaConFiliales : Empresa
    {
        //public Empresa Empresa
        //{
        //    get => default;
        //    set
        //    {
        //    }
        //}

        private List<Empresa> filiales = new List<Empresa>();
        public EmpresaConFiliales(string nombreEmpresa) : base(nombreEmpresa) { }

        public override void AddFilial(Empresa filial)
        {
            filiales.Add(filial);
        }

        public override void Display(int indent)
        {
            Console.WriteLine(new String('-', indent) + " " + _nombreEmpresa);
            foreach (Empresa f in filiales)
            {
                f.Display(indent + 2);
            }
        }

        public override void MostrarInformacion()
        {
            
            //Console.WriteLine("La empresa " + _nombreEmpresa + " tiene ofertas");
            Console.WriteLine("La empresa: " + _nombreEmpresa + " tiene " + numCoche + " coches");



        }
    }
}