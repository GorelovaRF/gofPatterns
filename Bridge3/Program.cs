using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge3
{
    class Program
    {
        static void Main(string[] args)
        {
            FormEspana formEsp1 = new FormEspana("España");
            FormEspana formEsp2 = new FormEspana("España");
            formEsp1.Implementor = new FormHTML();
            formEsp2.Implementor = new FormWPF();
            

           // formEsp1.mostrar();
           //formEsp1.crear("Formulario HTML España");
            formEsp1.mostrar();

            formEsp2.mostrar();


            FormPortugal formPort1 = new FormPortugal("Portugal");
            FormPortugal formPort2 = new FormPortugal("Portugal");
            formPort1.Implementor = new FormHTML();
            formPort2.Implementor = new FormWPF();
            // formEsp1.crear("Formulario HTML Portugal");
            formPort1.mostrar();
            formPort2.mostrar();

            Console.ReadKey();
        }
    }
}
