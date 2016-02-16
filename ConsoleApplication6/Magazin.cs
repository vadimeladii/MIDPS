using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    public class Magazin
    {
        List<Cereale> listCereale = null;
        List<Lactate> listLactate = null ;
        public String nameMagazin { get; set; }
        public int id { get; set; }

        public Magazin()
        {
            Console.WriteLine("introduce numele Magazinului");
            nameMagazin = Console.ReadLine();
            listLactate = new List<Lactate>();
            listCereale = new List<Cereale>();
        }

        public void addProdus(Produs produs)
        {
            if (produs is Lactate)
            {
                listLactate.Add((Lactate)produs);
            }else if(produs is Cereale)
            {
                listCereale.Add((Cereale)produs);
            }
        }

        public void addProdus(Produs produs,int posInitial)
        {
            if (produs is Lactate)
            {
                listLactate.Insert(posInitial, (Lactate)produs);
            }
            else if (produs is Cereale)
            {
                listCereale.Insert(posInitial,(Cereale)produs);
            }
        }

        public List<Cereale> getListCereale()
        {
            return listCereale;
        }

        public List<Lactate> getListLegume()
        {
            return listLactate;
        }

        public string showListCereale()
        {
            string text = null;
            foreach (Cereale cereale in listCereale)
            {
                text += cereale.ToString();
            }
            return text;

        }
        public string showListLegume()
        {
            string text = null;
            foreach (Lactate legume in listLactate)
            {
                    text += legume.ToString();
            }
            return text;
        }

        public override string ToString()
        {
            return "Magazinul: "+ nameMagazin + " \n "+ showListCereale() + showListLegume();
        }
    }
}

