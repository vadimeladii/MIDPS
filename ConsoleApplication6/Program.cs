using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        private static Dictionary<int, Magazin> mapMagazin = new Dictionary<int, Magazin>();
        private static Magazin magazin;
        private static int index = 0;
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. Introduce Magazin");
                Console.WriteLine("2. Show Magazin");
                Console.WriteLine("3. Alege magazinul dorit");
                Console.WriteLine("4. Introduce Ceriale");
                Console.WriteLine("5. ShowCereale");
                Console.WriteLine("6. Introduce Legume");
                Console.WriteLine("7. Show Legume");
                Console.WriteLine("8. Show totul info");
                Console.WriteLine("9. Sort");

                Console.WriteLine("Introduce o cifra ");

                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        mapMagazin.Add(++index, new Magazin());
                        magazin = mapMagazin[index];
                        break;
                    case 2:
                        showMagazin();
                        break;
                    case 3:
                        Console.WriteLine("Alege Magazinul dorita");
                        Console.WriteLine("------------------");
                        int i = Convert.ToInt32(Console.ReadLine());
                        magazin = mapMagazin[i];
                        break;
                    case 4:
                        magazin.addProdus((new Cereale()));
                        break;
                    case 5:
                        Console.WriteLine(magazin.showListProdus());
                        break;
                    case 6:
                        magazin.addProdus((new Legume()));
                        break;
                    case 7:
                        Console.WriteLine(magazin.showListCereale());
                        break;
                    case 8:
                        Console.WriteLine(magazin.ToString());
                        break;
                    case 9:
                        magazin.sortProdus();
                        break;
                    default:
                        break;
                }
            }
        }

        public static void showMagazin()
        {
            foreach(var map in mapMagazin)
            {
                Console.WriteLine("Key:{0} : Value {1}", map.Key, map.Value);
            }
        }
    }
}
