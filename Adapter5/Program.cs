using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter5
{
    class Program
    {
        static void Main(string[] args)
        {
            Documento doc1 = new DocumentoHTML();
            Documento doc2 = new Adapter();

            doc1.id = 1;
            doc1.contenido = "DOCUMENTO HTML";
            doc1.dibuja();
            doc1.imprime();


            doc2.id = 2;
            doc2.contenido = "DOCUMENTO PDF";
            doc2.dibuja();
            doc2.imprime();


         
            Console.ReadKey();


        }
    }
}
