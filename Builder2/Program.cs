using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder2
{
    class Program
    {
        static void Main(string[] args)
        {
            Vendedor v1 = new Vendedor(1, "Anastasiia");
            BuilderDocumentacion bHTML = new BuilderHTML();

            Vendedor v2 = new Vendedor(2,"Anna");
            BuilderDocumentacion bPDF = new BuilderPDF();

            v1.Builder = bHTML;
            v1.crearDocimento();
            v1.listaDoc();

            v2.Builder = bPDF;
            v2.crearDocimento();
            v2.listaDoc();


            Console.ReadKey();



        }
    }
}
