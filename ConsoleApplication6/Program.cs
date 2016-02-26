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
        private static List<Cereale> listCereale = new List<Cereale>();
        private static List<Lactate> listLactate = new List<Lactate>();

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
                Console.WriteLine("7. Adauga mai multe magazine");
                Console.WriteLine("8.Adauga la magazin ceva nou");
                Console.WriteLine("9. Arata toate informatia despre magazin");
                Console.WriteLine("10. Adauga o noua cereale ");
                Console.WriteLine("11. Adauga o noua lactata");
                Console.WriteLine("12 Show listCereale");
                Console.WriteLine("13 Show listLactate");

                Console.WriteLine("Introduce o cifra ");

                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        addMagazin();
                        break;
                    case 2:
                        show<Magazin>(listMagazin);
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
                        Console.WriteLine("1. Introduce ceriale");
                        Console.WriteLine("2. Arata ceriale");
                        Console.WriteLine("3. Sterge ceriale");
                        Console.WriteLine("4. Sterge mai mult ceriale");
                        Console.WriteLine("5. Sortare ceriale");
                        Console.WriteLine("6. Adauga mai multe ceriale");

                        Console.WriteLine("7. Introduce lactate");
                        Console.WriteLine("8. Arata lactate");
                        Console.WriteLine("9. Sterge lactate");
                        Console.WriteLine("10. Sterge mai multe lactate");
                        Console.WriteLine("11. Sortare lactate");
                        Console.WriteLine("12. Adauga mai multe lactate");

                        Console.WriteLine("Introduce o cifra ");

                        switch (Convert.ToInt32(Console.ReadLine()))
                        {
                            case 1:
                                showListCereale();
                                Console.WriteLine("introduceti care cereala doriti");
                                int ii = Convert.ToInt32(Console.ReadLine());
                                magazin.addProdus(listCereale[--ii]);
                                break;
                            case 2:
                                show<Cereale>(magazin.getListCereale());
                                break;
                            case 3:
                                remove<Cereale>(magazin.getListCereale(), idDelete());
                                break;
                            case 4:
                                Console.WriteLine("Introduce intre ce raza doriti sa stergeti elementele : ");
                                primPosition = Convert.ToInt32(Console.ReadLine());
                                finalPositon = Convert.ToInt32(Console.ReadLine());
                                remove<Cereale>(magazin.getListCereale(), primPosition, finalPositon);
                                break;
                            case 5:
                                sorts<Cereale>(magazin.getListCereale());
                                break;
                            case 6:
                                Console.WriteLine("Alege positia initiala");
                                init = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Numarul de date care doriti sa adaugati");
                                nrDate = Convert.ToInt32(Console.ReadLine());
                                for (int j = 0; j < nrDate; j++)
                                {
                                    showListCereale();
                                    Console.WriteLine("introduceti care cereala doriti");
                                    ii = Convert.ToInt32(Console.ReadLine());
                                    magazin.addProdus(listCereale[--ii],init);
                                }
                                break;
                            case 7:
                                showListLactate();
                                Console.WriteLine("introduceti care lactate doriti");
                                ii = Convert.ToInt32(Console.ReadLine());
                                magazin.addProdus(listLactate[--ii]);
                                break;
                            case 8:
                                show<Lactate>(magazin.getListLegume());
                                break;
                            case 9:
                                remove<Lactate>(magazin.getListLegume(), idDelete());
                                break;
                            case 10:
                                Console.WriteLine("Introduce intre ce raza doriti sa stergeti elementele : ");
                                primPosition = Convert.ToInt32(Console.ReadLine());
                                finalPositon = Convert.ToInt32(Console.ReadLine());
                                remove<Lactate>(magazin.getListLegume(), primPosition, finalPositon);
                                break;
                            case 11:
                                sorts<Lactate>(magazin.getListLegume());
                                break;
                            case 12:
                                Console.WriteLine("Alege positia initiala");
                                init = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Numarul de date care doriti sa adaugati");
                                nrDate = Convert.ToInt32(Console.ReadLine());
                                for (int j = 0; j < nrDate; j++)
                                {
                                    magazin.addProdus((new Lactate()), init);
                                }
                                break;
                        }
                        break;
                    case 9:
                        Console.WriteLine(magazin.ToString());
                        break;
                    case 10:
                        listCereale.Add(new Cereale());
                        break;
                    case 11:
                        listLactate.Add(new Lactate());
                        break;
                    case 12:
                        showListCereale();
                        break;
                    case 13:
                        showListCereale();
                        break;
                    default:
                        Console.WriteLine("Introduce cifra corecta");
                        break;
                }
            }
        }

        public static void showListCereale()
        {
            int i = 0;
            foreach(Cereale cereale in listCereale)
            {
                Console.WriteLine("Key" + (++i) + "Nume" + cereale.nameComponentProdus);
            }
        }

        public static void showListLactate()
        {
            int i = 0;
            foreach(Lactate lactate in listLactate)
            {
                Console.WriteLine("Key" + (++i) + "Nume" + lactate.nameComponentProdus);
            }
        }

        public static void show<T>(List<T> list)
        {
            foreach(Object objec in list)
            {
                Console.WriteLine(objec.ToString());
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
            listMagazin.Insert(--posInitial, magazin);
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
