using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Univ
    {
        public String nameUniv { get; set; }
        List<Curs> listCurs = new List<Curs>();
        List<Student> listStudent = new List<Student>();
        int incrementCurs=0;
        int incrementStudent = 0;

        public void addCurs()
        {
            Console.WriteLine("Introduce id : ");
            int idCurs;
            idCurs = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Introduce numele cursului : ");
            string nameCurs = Console.ReadLine();
            Console.WriteLine("Introduce numele profesorului : ");
            string nameProf = Console.ReadLine();

            listCurs.Add(new Curs(idCurs,nameCurs,nameProf));
            incrementCurs++;
        }

        public void addStudent()
        {
            Console.WriteLine("Introduce id : ");
            int idStudent;
            idStudent = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce numele studentului : ");
            string nameStudent = Console.ReadLine();
            Console.WriteLine("Introduce ani studentului : ");
            int ageStudent =Convert.ToInt32(Console.ReadLine());
            listStudent.Add(new Student(1, nameStudent, ageStudent));
        }

        public void addCollectionCurs(int nr)
        {
            for(int i=0 ; i< nr ; i++)
            {
                addCurs();
            }
        }
        

        public void clearCurs()
        {
            listCurs.RemoveAt(1);
            incrementCurs--;
        }

        public void clearStudent()
        {
            listStudent.RemoveAt(1);
        }

        public String showCurs()
        {
            String infoCurs="";
            foreach(Curs curs in listCurs)
            {
                infoCurs += curs.ToString();
            }
            return infoCurs;
        }

        public void showStudent()
        {
            foreach(Student student in listStudent)
            {
                Console.WriteLine(student.ToString());
            }
        }
        

        public List<Curs> getListCurs()
        {
            return listCurs;
        }

        public List<Student> getListStudent()
        {
            return listStudent;
        }

        public override string ToString()
        {
            return String.Format("Name univ: {0} ",nameUniv);
        }
    }
}
