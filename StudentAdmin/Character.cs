namespace StudentAdmin;

public class Karakter
{
    public Student Student { get; set; }
    public Karakter(Student student)
    {
        Student = student;
    }

    public void SkrivUtInfo()
    {
        //Karakter anjaKarakter = new Karakter(Student.student.anja, engelskS, 6);
       // Karakter bjarneKarakter = new Karakter(bjarne, norskS, 5);
        //Console.WriteLine("Student: " + Student + "\nFag: " + Subject + "\nKarakter: " + Karakterverdi);

        Student.SkrivUtInfo();
    }
}