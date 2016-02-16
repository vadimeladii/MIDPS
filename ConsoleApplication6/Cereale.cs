using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    public class Cereale : Produs
    {
        public string cantitateUmiditate { get; set; }
        public Cereale() : base()
        {
            Console.WriteLine("Introduce cantitatea umiditate : ");
            cantitateUmiditate = Console.ReadLine();
        }

        public Cereale(String nameComponentProdus ,int cantitateaProdus , String timpulFierberi) : base(nameComponentProdus, cantitateaProdus)
        {
            this.cantitateUmiditate = timpulFierberi;
        }

        public override string ToString()
        {
            return  "Cereale :"+nameComponentProdus + " \n Cantitatea :" + cantitateaProdus + " \n Cantitatea de umiditate : " + cantitateUmiditate+"\n";
        }
    }
}
