using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    public abstract class Produs
    {
        public int id { get; set; }
        public String nameComponentProdus { get; set; }
        public int cantitateaProdus { get; set; }


        public Produs()
        {
            /*Console.WriteLine("Introduce id  : ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce numele cerealei : ");
            nameComponentProdus = Console.ReadLine();
            Console.WriteLine("Introduce cantitatea produs : ");
            cantitateaProdus = Convert.ToInt32(Console.ReadLine());*/
        }

        public Produs(int id,String nameComponentProdus, int cantitateaProdus) : this()
        {
            this.id = id;
            this.nameComponentProdus = nameComponentProdus;
            this.cantitateaProdus = cantitateaProdus;
        }
    }
}
