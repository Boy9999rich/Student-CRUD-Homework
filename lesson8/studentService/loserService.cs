namespace lesson8.studentService;
   using lesson8.Model;


    public class loserService
    {
        private List<Student> students;
    public loserService()
    {
        students = new List<Student>();
        DateSeed();
    }

    public Student AddStudent(Student student)
    {
        student.Id = Guid.NewGuid();
        students.Add(student);
        return student;
    }
    public bool DeleteStudent(Guid studentId)
    {
        var exists = false;
        foreach (var student in students)
        {
            if (student.Id == studentId)
            {
                students.Remove(student);
                exists = true;
            }
        }
        return exists;
    }
    public bool UpdateStudent(Student updatedStudent)
    {
        for (var i = 0; i < students.Count - 1; i++)
        {
            if (students[i].Id == updatedStudent.Id)
            {
                students[i] = updatedStudent;
                return true;
            }
        }
        return false;
    }
    public Student GetByid(Guid studentId)
    {
        foreach (var student in students)
        {
            if (student.Id == studentId)
            {
                return student;
            }
        }
        return null;
    }
    public List<Student> GetAllStudent()
    {
        return students;
    }
    private void DateSeed()
    {
        var student1 = new Student()
        {
            Id = Guid.NewGuid(),
            Name = "SaidAkbar",
            LastName = "Qayumxo'jayev",
            Location = "Eski shahar",
            Age = 24,
            Degree = 5,
            OpenedDay = DateTime.Now, 
        };
        var student2 = new Student()
        {
            Id = Guid.NewGuid(),
            Name = "Suhrob",
            LastName = "Ziyoyev",
            Location = "xayrandara",
            Age = 25,
            Degree = 10,
            OpenedDay = DateTime.Now,
        };
        students.Add(student1);
        students.Add(student2);
    }
    }

