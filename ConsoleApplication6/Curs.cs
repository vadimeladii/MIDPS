using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Curs
    {

        public Curs()
        {
        }

        public Curs(int idCurs,String nameCurs,String nameProf)
        {
           this.idCurs = idCurs;
           this.nameCurs = nameCurs;
           this.nameProf = nameProf;
        }

        public int idCurs { get; set; }
        public String nameCurs { get; set; }
        public String nameProf { get; set; }

        public override string ToString()
        {
            return String.Format("IdCurs : {0} \n NameCurs : {1} \n NameProf {2} ",new Object[] { idCurs, nameCurs, nameProf });
        }

        public void showListStudent(List<Student> listStudent)
        {
            foreach(Student student in listStudent)
            {
                Console.WriteLine(student);
            }
        }

    }
}
