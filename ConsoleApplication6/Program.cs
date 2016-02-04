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
                Console.WriteLine("4. Introduce universitatea");
                Console.WriteLine("4. Afiseaza nr de niversitati");

                Console.WriteLine("Introduce o cifra ");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        univ.addCurs();
                        break;
                    case 2:
                        univ.showCurs();
                        break;
                    case 3:
                        Console.WriteLine("1. Introduce nr de cursuri care doriti sa adaugati :");
                        int nrCurs = Convert.ToInt32(Console.ReadLine());
                        univ.addCollectionCurs(nrCurs);
                        break;
                    case 4:
                        mapUniver.Add(++index, new Univ());
                        univ = mapUniver[index];
                        Console.WriteLine ( "introduce numele universitati");
                        String name=Console.ReadLine();
                        univ.nameUniv = name;
                        break;
                    case 5:
                        Console.WriteLine("Alege universitatea dorita");
                        showUniv();

                        break;
                    default:
                        break;
                }
            }
        }

        public static void showUniv()
        {
            foreach(Univ univ in mapUniver.Values)
            {
                Console.WriteLine(univ.nameUniv);
            }
        }
    }
}
