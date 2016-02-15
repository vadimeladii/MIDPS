using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Legume : Produs
    {
        public string grame { get; set; }
        public Legume() : base()
        {
            Console.WriteLine("Introduce timpul de producere : ");
            string grame = Console.ReadLine();
        }

        public Legume(String nameComponentProdus, int cantitateaProdus, String grame) : base(nameComponentProdus, cantitateaProdus)
        {
            this.grame = grame;
        }

        public override string ToString()
        {
            return "Numele produsului :" + nameComponentProdus + " \n Cantitatea Produs" + cantitateaProdus + " \n Timpul de fierbere" + grame;
        }

    }
}
