using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Student
    {

        public Student() { }
        public Student(int idStudent,String nameStudent,int ageStudent)
        {
            this.idStudent = idStudent;
            this.nameStudent = nameStudent;
            this.ageStudent = ageStudent;
        }

        public int idStudent { get; set; }
        public String nameStudent { get; set; }
        public int ageStudent { get; set; }

        public override string ToString()
        {
            return String.Format("idStudent {0} \n NameStudent {1} \n AgeStudnet {2}",idStudent,nameStudent,ageStudent);
        }
    }
}
