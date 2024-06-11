namespace StudentAdmin;

public class Subject
{
    public string Fagkode { get; set; }
    public string FagNavn { get; set; }
    public int Studiepoeng { get; set; }

    public Subject(string fagkode, string fagNavn, int studiepoeng)
    {
        Fagkode = fagkode;
        FagNavn = fagNavn;
        Studiepoeng = studiepoeng;
    }

    public void SkrivUtInfo()
    {
        Console.WriteLine("\nFagkode: " + Fagkode + "\nFagnavn: " + FagNavn + "\nStudiepoeng: " + Studiepoeng);
    }
    public static List<Subject> Subjects()
    {
        return new List<Subject>()
        {
            new Subject("EN1234", "Engelsk Skriftlig", 15),
            new Subject("EN5678", "Engelsk Muntlig", 15),
            new Subject("NO123", "Norsk Skriftlig", 10),
            new Subject("NO456", "Norsk Muntlig", 10),
            new Subject("NO789", "Norsk Nynorsk", 10),
        };
    }
}