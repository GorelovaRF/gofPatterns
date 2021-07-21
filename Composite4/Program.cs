using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite4
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpresaSinFiliales emSin1 = new EmpresaSinFiliales("Empresa Primera Sin Filiales");
            emSin1.AnadirCoche();
            emSin1.AnadirCoche();
            emSin1.AnadirCoche();
            emSin1.Display(1);
            emSin1.MostrarInformacion();


            EmpresaConFiliales em1 = new EmpresaConFiliales("Primera Empresa");
            em1.AddFilial(new EmpresaSinFiliales("Primera Empresa Filial 1"));
            em1.AddFilial(new EmpresaSinFiliales("Primera Empresa Filial 2"));
            em1.AnadirCoche();
            em1.AnadirCoche();
            em1.Display(1);
            em1.MostrarInformacion();



            EmpresaConFiliales em2 = new EmpresaConFiliales("Segunda Empresa");
            em2.AddFilial(new EmpresaSinFiliales("Segunda Empresa Filial 1"));
            em2.AnadirCoche();
            em2.Display(1);     
            em2.MostrarInformacion();



            Console.ReadKey();




        }
    }
}
