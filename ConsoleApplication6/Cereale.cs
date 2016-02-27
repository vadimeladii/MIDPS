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
           /* Console.WriteLine("Introduce cantitatea umiditate : ");
            cantitateUmiditate = Console.ReadLine();*/
        }

        public Cereale(int idCereale , String nameComponentProdus ,int cantitateaProdus , String timpulFierberi) : base(idCereale,nameComponentProdus, cantitateaProdus)
        {
            this.cantitateUmiditate = timpulFierberi;
        }

        public override string ToString()
        {
            return  "Id: "+id+"  Cereale :"+nameComponentProdus + " \n Cantitatea :" + cantitateaProdus + " \n Cantitatea de umiditate : " + cantitateUmiditate+"\n";
        }
    }
}
