using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        private static List<Magazin> listMagazin = new List<Magazin>();
        private static Magazin magazin;
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Menu");

                Console.WriteLine("1. Adauga un magazin");
                Console.WriteLine("2. Arata magazinele");
                Console.WriteLine("3. Alege magazinul");
                Console.WriteLine("4. Sterge magazin");
                Console.WriteLine("5. Sterge o serie de magazine");
                Console.WriteLine("6. Sortare magazine");
                Console.WriteLine("7. Adauga mai multe mesage");

                Console.WriteLine("8. Introduce ceriale");
                Console.WriteLine("9. Arata ceriale");
                Console.WriteLine("10. Sterge ceriale");
                Console.WriteLine("11. Sterge mai mult ceriale");
                Console.WriteLine("12. Sortare ceriale");
                Console.WriteLine("13. Adauga mai multe ceriale");

                Console.WriteLine("14. Introduce lactate");
                Console.WriteLine("15. Arata lactate");
                Console.WriteLine("16. Sterge lactate");
                Console.WriteLine("17. Sterge mai multe lactate");
                Console.WriteLine("18. Sortare lactate");
                Console.WriteLine("19. Adauga mai multe lactate");

                Console.WriteLine("20. Arata toate informatia despre magazin");

                Console.WriteLine("Introduce o cifra ");

                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        addMagazin();
                        break;
                    case 2:
                        showMagazin();
                        break;
                    case 3:
                        Console.WriteLine("Alege Magazinul dorita");
                        int i = Convert.ToInt32(Console.ReadLine());
                        magazin = listMagazin[i - 1];
                        break;
                    case 4:
                        remove<Magazin>(listMagazin, idDelete());
                        break;
                    case 5:
                        Console.WriteLine("Introduce intre ce raza doriti sa stergeti elementele : ");
                        int primPosition = Convert.ToInt32(Console.ReadLine());
                        int finalPositon = Convert.ToInt32(Console.ReadLine());
                        remove<Magazin>(listMagazin, primPosition, finalPositon);
                        break;
                    case 6:
                        sorts<Magazin>(listMagazin);
                        break;
                    case 7:
                        Console.WriteLine("Alege positia initiala");
                        int init = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Numarul de date care doriti sa adaugati");
                        int nrDate = Convert.ToInt32(Console.ReadLine());
                        for (int j = 0; j < nrDate; j++)
                        {
                            addMagazin(init);
                        }
                        break;
                    case 8:
                        magazin.addProdus((new Cereale()));
                        break;
                    case 9:
                        Console.WriteLine(magazin.showListCereale());
                        break;
                    case 10:
                        remove<Cereale>(magazin.getListCereale(), idDelete());
                        break;
                    case 11:
                        Console.WriteLine("Introduce intre ce raza doriti sa stergeti elementele : ");
                        primPosition = Convert.ToInt32(Console.ReadLine());
                        finalPositon = Convert.ToInt32(Console.ReadLine());
                        remove<Cereale>(magazin.getListCereale(), primPosition, finalPositon);
                        break;
                    case 12:
                        sorts<Cereale>(magazin.getListCereale());
                        break;
                    case 13:
                        Console.WriteLine("Alege positia initiala");
                         init = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Numarul de date care doriti sa adaugati");
                         nrDate = Convert.ToInt32(Console.ReadLine());
                        for (int j = 0; j < nrDate; j++)
                        {
                            magazin.addProdus((new Cereale()), init);
                        }    

                        break;
                    case 14:
                        magazin.addProdus((new Lactate()));
                        break;
                    case 15:
                        Console.WriteLine(magazin.showListLegume());
                        break;
                    case 16:
                        remove<Lactate>(magazin.getListLegume(), idDelete());
                        break;
                    case 17:
                        Console.WriteLine("Introduce intre ce raza doriti sa stergeti elementele : ");
                        primPosition = Convert.ToInt32(Console.ReadLine());
                        finalPositon = Convert.ToInt32(Console.ReadLine());
                        remove<Lactate>(magazin.getListLegume(), primPosition, finalPositon);
                        break;
                    case 18:
                        sorts<Lactate>(magazin.getListLegume());
                        break;
                    case 19:
                        Console.WriteLine("Alege positia initiala");
                        init = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Numarul de date care doriti sa adaugati");
                        nrDate = Convert.ToInt32(Console.ReadLine());
                        for (int j = 0; j < nrDate; j++)
                        {
                            magazin.addProdus((new Lactate()), init);
                        }
                        break;
                    case 20:
                        Console.WriteLine(magazin.ToString());
                        break;
                    default:
                        break;
                }
            }
        }

       public static void sorts<T>(List<T> list)
        {
            list.Sort(delegate (T x, T y)
            {
                if (x.ToString() == null && y.ToString() == null) return 0;
                else if (x.ToString() == null) return -1;
                else if (y.ToString() == null) return 1;
                else return x.ToString().CompareTo(y.ToString());
            });
        }

        public static void addMagazin()
        {
            magazin = new Magazin();
            listMagazin.Add(magazin);
        }

        public static void addMagazin(int posInitial)
        {
            magazin = new Magazin();
            listMagazin.Insert(posInitial, magazin);
        }

        public static int idDelete()
        {
            Console.WriteLine("Introduce id care doresti sa stergi : ");
            int id = Convert.ToInt32(Console.ReadLine());
            return id;
        }

        public static void showMagazin()
        {
            int i = 1;
            foreach (Magazin magazin in listMagazin)
            {
                Console.WriteLine("Key:{0} : Value {1}", i++, magazin.nameMagazin);
            }
        }

        public static void remove<T>(List<T> list, int i)
        {
            if (list is List<Magazin>)
            {
                i--;
                Object objects = list[i];
                if (objects is Magazin)
                {
                    Magazin magazins = (Magazin)objects;
                    magazin.getListCereale().Clear();
                    magazin.getListLegume().Clear();
                    list.RemoveAt(i);
                }
            }
            else
            {
                list.RemoveAt(--i);
            }
        }

        public static void remove<T>(List<T> list, int primPosition,int finalPosition)
        {
            if (list is List<Magazin>)
            {
                for (int i = primPosition; i < finalPosition; i++)
                {
                    Object objects = list[i];
                    Magazin magazins = (Magazin)objects;
                    magazin.getListCereale().Clear();
                    magazin.getListLegume().Clear();
                }
                list.RemoveRange(--primPosition, --finalPosition);
            }
            else
            {
                list.RemoveRange(--primPosition,--finalPosition);
            }
        }
    }
}
