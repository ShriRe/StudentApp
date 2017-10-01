using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuNewStudentApp
{
    class Program
    {
#region Methods
        static void Main(string[] args)
        {
           
            var student = new AddStudent();
           // student.StudentId = 000599086;
            student.EmailAddress = "shreerekha.dodla16@northwestu.edu";
            //student.GradGPA = 3.0;
            student.StudentType = StudentType.Masters;

            var newStudent= student.GPA (3);

            Console.WriteLine($"SID : {student.StudentId}) ,EA: {student.EmailAddress} , GPA : {student.GradGPA} ,ST :{student.StudentType} ");

            var student2 = new AddStudent();

            Console.WriteLine($"SID : {student2.StudentId}) ,EA: {student2.EmailAddress} , GPA : {student2.GradGPA} ,ST :{student2.StudentType} ");
            #endregion
        }
    }
}
