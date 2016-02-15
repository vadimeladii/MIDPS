using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    public class Cereale : Produs
    {
        public string timpuFireberi { get; set; }
        public Cereale() : base()
        {
            Console.WriteLine("Introduce timpul de producere : ");
            timpuFireberi = Console.ReadLine();
        }

        public Cereale(String nameComponentProdus ,int cantitateaProdus , String timpulFierberi) : base(nameComponentProdus, cantitateaProdus)
        {
            this.timpuFireberi = timpulFierberi;
        }

        public override string ToString()
        {
            return "Numele produsului :" + nameComponentProdus + " \n Cantitatea Produs" + cantitateaProdus + " \n Timpul de fierbere" + timpuFireberi;
        }

    }
}
