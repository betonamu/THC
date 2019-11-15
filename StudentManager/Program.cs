using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager
{
    class Program
    {
        static Student[] studentList;
        static void Main(string[] args)
        {
            //Nhap tong so sinh vien
            int numberOfStudent;
            try
            {
                Console.Write("Num of Student = ");
                numberOfStudent = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid Input Number Of Student!- {0}", ex.Message);
                Console.ReadKey();
                return;
            }
            // Tao danh sach sinh vien
            InputStudentList(numberOfStudent);
            OutputStudent();
            Console.ReadKey();
        }

        /// <summary>
        /// Ham xuat danh sach sinh vien
        /// </summary>
        private static void OutputStudent() {

            Console.Write("List of Student");
            foreach (var student  in studentList)
            {
                Console.WriteLine("Student Id = {0}", student.StudentID);
                Console.WriteLine("Fullname = {0}", student.FullName);
                Console.WriteLine("Mark = {0}", student.Mark);
                Console.WriteLine("Falculty = {0}", student.Falculty);
            }
        }

        private static void InputStudentList(int numberOfStudent)
        {
            //Tao mang luu danh sach sinh vien
            studentList = new Student[numberOfStudent];
            for (int i = 0; i < numberOfStudent; i++)
            {
                Student student = new Student();
                Console.Write("Student Id = ");
                student.StudentID = Convert.ToInt32(Console.ReadLine());
                Console.Write("Full name = ");
                student.FullName = Console.ReadLine();
                Console.Write("Mark = ");
                student.Mark = float.Parse(Console.ReadLine());
                Console.Write("Falculty = ");
                student.Falculty = Console.ReadLine();
                //luu doi tuong sinh vien vao danh sach.
                studentList[i] = student;
            }
        }
    }
}
