using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        private static Dictionary<int, Univ> mapUniver = new Dictionary<int, Univ>();
        private static Univ univ;
        private static int index = 0;
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. Introduce curs");
                Console.WriteLine("2. Show curs");
                Console.WriteLine("3. Introduce mai multe cursuri odata");
                Console.WriteLine("4. Introduce student");
                Console.WriteLine("5. Introduce mai multi studenti odata");
                Console.WriteLine("6. Show student");
                Console.WriteLine("7. Introduce universitatea");
                Console.WriteLine("8. Afiseaza nr de niversitati");
                Console.WriteLine("9. Afisarea toatei info destpre universitate");

                Console.WriteLine("Introduce o cifra ");

                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        univ.addCurs();
                        break;
                    case 2:
                        Console.WriteLine(univ.showCurs());
                        break;
                    case 3:
                        Console.WriteLine("1. Introduce nr de cursuri care doriti sa adaugati :");
                        int nrCurs = Convert.ToInt32(Console.ReadLine());
                        univ.addCollectionCurs(nrCurs);
                        break;
                    case 4:

                        break;
                    case 5:

                        break;
                    case 6:

                        break;
                    case 7:
                        mapUniver.Add(++index, new Univ());
                        univ = mapUniver[index];
                        Console.WriteLine ( "introduce numele universitati");
                        String name=Console.ReadLine();
                        univ.nameUniv = name;
                        break;
                    case 8:
                        Console.WriteLine("Alege universitatea dorita");
                        showUniv();
                        Console.WriteLine("------------------");
                        int i =Convert.ToInt32(Console.ReadLine());
                        univ = mapUniver[i];
                        break;
                    case 9:
                        univ.showTouteInfo();
                        break;
                    default:
                        break;
                }
            }
        }

        public static void showUniv()
        {
            foreach(var map in mapUniver)
            {
                Console.WriteLine("Key:{0} : Value {1}", map.Key, map.Value);
            }
        }
    }
}
