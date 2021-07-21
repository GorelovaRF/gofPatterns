using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command6._2
{
   public class Coche
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public string Discout { get; set; }
  
        public Coche(string name, double price,string disc)
        {
            Name = name;
            Price = price;
            Discout = disc;
        }
        
         public void Display()
        {
            Console.WriteLine(Name + " " + Price.ToString());
            Console.WriteLine(" Discuento: " + Discout);
        }

    }


}
