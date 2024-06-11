namespace StudentAdmin;

public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Studieprogram { get; set; }
    public string StudentId { get; set; }

    public List<Subject> AllSubjects { get; set; }


    public Student(string name, int age, string studieprogram, string studentId)
    {
        Name = name;
        Age = age;
        Studieprogram = studieprogram;
        StudentId = studentId;
        AllSubjects = new List<Subject>();
    }

    public void GiveSubjects(Subject subject)
    {
        AllSubjects.Add(subject);
    }

    public void SkrivUtInfo()
    {
        Console.WriteLine("\nNavn: " + Name + "\nAlder: " + Age + "\nProgram: " + Studieprogram + "\nID: " + StudentId);
        Console.WriteLine("Alle fag: ");
        foreach (Subject subject in AllSubjects)
        {
            subject.SkrivUtInfo();
        }
    }

    public static List<Student> Students()
    {
        return new List<Student>()
        {
            new("Anja", 17, "Elektro", "AB123"),
            new Student("Bjarne", 17, "Helse", "BC456"),
        };

    }


    

    
}
