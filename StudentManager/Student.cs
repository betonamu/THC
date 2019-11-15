using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager
{
    class Student
    {
        //Ctrl + k + C :Comment
        //Ctrl + k + u : UnComment
        //Ctrl + k + D : Format Code
        public int StudentID { get; set; }
        public String FullName { get; set; }
        public float Mark { get; set; }
        public String Falculty { get; set; }

        public Student()
        {

        }
        public Student(int studentID,String fullName,float mark,String falculty)
        {
            this.StudentID = studentID;
            this.FullName = fullName;
            this.Mark = mark;
            this.Falculty = falculty;
        }
    }
}
