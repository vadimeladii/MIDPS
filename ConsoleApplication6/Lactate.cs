using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    public class Lactate : Produs
    {
        public string time { get; set; }
        public Lactate() : base()
        {
            Console.WriteLine("Introduce timpul valabil : ");
            int time = Convert.ToInt32(Console.ReadLine());
        }

        public Lactate(String nameComponentProdus, int cantitateaProdus, String grame) : base(nameComponentProdus, cantitateaProdus)
        {
            this.time = time;
        }

        public override string ToString()
        {
            return "Lactate :" + nameComponentProdus + " \n Cantitatea :" + cantitateaProdus + " \n Timpul de valabilitate : " + time+"\n";
        }
    }
}
