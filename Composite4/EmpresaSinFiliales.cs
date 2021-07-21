using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite4
{
    public class EmpresaSinFiliales : Empresa
    {


        public EmpresaSinFiliales(string nombreEmpresa) : base(nombreEmpresa) { }
        public override void AddFilial(Empresa filial)
        {
            Console.WriteLine("No es posible anadir filial ya que la empresa no lo tiene ");
        }

        public override void Display(int indent)
        {
            Console.WriteLine(new String('-', indent) + " " + _nombreEmpresa );
            
        }

        public override void MostrarInformacion()
        {
           
          //  Console.WriteLine("La empresa " + _nombreEmpresa + " tiene ofertas");
            Console.WriteLine("La empresa: " + _nombreEmpresa + " tiene " + numCoche + " coches");

            
        }
    }
}