using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    public class Magazin
    {
        List<Produs> listProdus = null;
        public String nameMagazin { get; set; }


        public Magazin()
        {
            Console.WriteLine("introduce numele Magazinului");
            nameMagazin = Console.ReadLine();
            listProdus = new List<Produs>();
        }

        public void addProdus(Produs produs)
        {
            listProdus.Add(produs);
        }

        public List<Produs> getListProdus()
        {
            return listProdus;
        }

        public string showListProdus()
        {
            string text = null;
            foreach(Produs produs in listProdus)
            {
                text += produs.ToString();
            }
            return text;
           
        }
        public string showListCereale()
        {
            string text = null;
            foreach(Produs produs in listProdus)
            {
                if (produs is Cereale)
                {
                    text += produs.ToString();
                }
            }
            return text;
        }

        public void sortProdus()
        {
            listProdus.Sort();
        }

        public void deleteProdus(int id)
        {
            listProdus.RemoveAt(id);
        }

        public override string ToString()
        {
            return "Magazinul :" +nameMagazin + "Produsele :" + showListProdus();
        }
    }
    public class Part : IEquatable<Produs>, IComparable<Produs>
    {
        public string nameComponentProdus { get; set; }

        public int cantitateaProdus { get; set; }

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
        // Should also override == and != operators.

    }
}
