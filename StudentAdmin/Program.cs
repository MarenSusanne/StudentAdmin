using System.Data;

namespace StudentAdmin
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Student> studentList = Student.Students();

            List<Karakter> karakters = new List<Karakter>()
            {
                new (studentList[0]),
                new Karakter(studentList[1])
            }; 
            
            foreach (Karakter karakter in karakters)
            {
                karakter.SkrivUtInfo();
            }

        }
    }
}
