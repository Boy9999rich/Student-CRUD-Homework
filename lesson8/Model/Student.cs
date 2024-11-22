namespace lesson8.Model;

public class Student
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public string Location { get; set; }
    public int Age { get; set; }
    public int Degree { get; set; }
    public DateTime OpenedDay{ get; set; }
}
