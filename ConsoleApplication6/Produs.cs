using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    public abstract class Produs
    {
        public String nameComponentProdus { get; set; }
        public int cantitateaProdus { get; set; }


        public Produs()
        {
            Console.WriteLine("Introduce numele cerealei : ");
            nameComponentProdus = Console.ReadLine();
            Console.WriteLine("Introduce cantitatea produs : ");
            cantitateaProdus = Convert.ToInt32(Console.ReadLine());
        }

        public Produs(String nameComponentProdus, int cantitateaProdus) : this()
        {
            this.nameComponentProdus = nameComponentProdus;
            this.cantitateaProdus = cantitateaProdus;
        }
    }
}
