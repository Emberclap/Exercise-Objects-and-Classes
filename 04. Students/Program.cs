namespace _04._Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();   
            for (int i = 0; i < n; i++)
            {
                List<string> studentInformation = Console.ReadLine()
                    .Split()
                    .ToList();
                Student student = new Student(studentInformation[0], studentInformation[1], double.Parse(studentInformation[2]));
                students.Add(student);
            }
            foreach (Student student in students.OrderByDescending(x => x.Grade))
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:F2}");
            }
        }
    }
    class Student
    {
        public Student(string firstName, string lastName, double grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;

        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }
    }
}