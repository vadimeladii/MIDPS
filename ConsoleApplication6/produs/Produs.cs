using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    public abstract class Produs : IEquatable<Produs>, IComparable<Produs>
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

        public Produs(String nameComponentProdus,int cantitateaProdus) : this()
        {
            this.nameComponentProdus = nameComponentProdus;
            this.cantitateaProdus = cantitateaProdus;
        }

        public override string ToString()
        {
            return "Cantitate: " + cantitateaProdus + "   Name Component: " + nameComponentProdus;
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Part objAsPart = obj as Part;
            if (objAsPart == null) return false;
            else return Equals(objAsPart);
        }
        public int SortByNameAscending(string name1, string name2)
        {

            return name1.CompareTo(name2);
        }

        // Default comparer for Part type.
        public int CompareTo(Produs comparePart)
        {
            // A null value means that this object is greater.
            if (comparePart == null)
                return 1;

            else
                return this.cantitateaProdus.CompareTo(comparePart.cantitateaProdus);
        }
        public override int GetHashCode()
        {
            return cantitateaProdus;
        }
        public bool Equals(Produs other)
        {
            if (other == null) return false;
            return (this.cantitateaProdus.Equals(other.cantitateaProdus));
        }

    }

}
