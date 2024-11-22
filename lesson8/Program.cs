using lesson8.studentService;
using lesson8.Model;

namespace lesson8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RunFrontend();
        }
        public static void RunFrontend()
        {
            var studentService = new loserService();
            while (true)
            {
                Console.WriteLine(DateTime.Now);
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Delete");
                Console.WriteLine("3. Update");
                Console.WriteLine("4. GetAll");
                Console.WriteLine("5. GetById");
                Console.WriteLine("Enter =>>");
                var option = Console.ReadLine();

                if (option == "1")
                {
                    var student = new Student();
                    Console.Write("Enter name");
                    student.Name = Console.ReadLine();
                    Console.Write("Enter LastName");
                    student.LastName = Console.ReadLine();
                    Console.Write("Enter Location");
                    student.Location = Console.ReadLine();
                    Console.WriteLine("Enter Age");
                    student.Age = int.Parse(Console.ReadLine());
                    Console.Write("Enter Degree");
                    student.Degree = int.Parse(Console.ReadLine());
                    student.OpenedDay = DateTime.Now;

                    studentService.AddStudent(student);
                }
                else if (option == "2")
                {
                    Console.Write("Enter Id To Delete");
                    var id = Guid.Parse(Console.ReadLine());
                    var resFromFunc = studentService.DeleteStudent(id);
                    Console.WriteLine(resFromFunc);
                }
                else if (option == "3")
                {
                    var student = new Student();
                    Console.Write("Enter Id to Update");
                    student.Id = Guid.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Name");
                    student.Name = Console.ReadLine();
                    Console.WriteLine("Enter Lastname");
                    student.LastName = Console.ReadLine();
                    Console.WriteLine("Enter Location");
                    student.Location = Console.ReadLine();
                    Console.Write("Enter Age");
                    student.Age = int.Parse(Console.ReadLine());
                    Console.Write("Enter degree ");
                    student.Degree = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter dateTime");
                    student.OpenedDay = DateTime.Parse(Console.ReadLine());

                    studentService.UpdateStudent(student);
                }
                else if (option == "4")
                {
                    var students = studentService.GetAllStudent();

                    foreach (var student in students)
                    {
                        var info = $"Id : {student.Id}, Name : {student.Name}," +
                            $"Lastname : {student.LastName}, Location : {student.Location}," +
                            $"Age : {student.Age}, Degree : {student.Degree}, " +
                            $"OpenedDay : {student.OpenedDay}";

                        Console.Write(info);

                    }
                }
                else if (option == "5")
                {
                    Console.Write("Enter id to get");
                    var id = Guid.Parse(Console.ReadLine());

                    var student = studentService.GetByid(id);
                    string info = $"Id : {student.Id}, Name : {student.Name}," +
                            $"Lastname : {student.LastName}, Location : {student.Location}," +
                            $"Age : {student.Age}, Degree : {student.Degree}, " +
                            $"OpenedDay : {student.OpenedDay}";

                    Console.Write(info);

                }
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
