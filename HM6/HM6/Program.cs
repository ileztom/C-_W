namespace HM6
{
    internal class Program
    {
        public class Student
        {
            public string Name { get; set; }
            public string Group { get; set; }
            public List<double> Grades { get; set; }

            public Student(string name, string group, List<double> grades)
            {
                Name = name;
                Group = group;
                Grades = grades;
            }

            public double AverageGrade()
            {
                double sum = 0;
                foreach(int grade in Grades)
                {
                    sum = grade;
                }
                return sum;
            }
        }
        static void Main(string[] args)
        {
            Stack<Student> studentStack = new Stack<Student>();

            studentStack.Push(new Student("Иванов И.И.", "Группа 1", new List<double> {5.0}));
            studentStack.Push(new Student("Петров П.П.", "Группа 2", new List<double> {4.0}));
            studentStack.Push(new Student("Сидоров С.С.", "Группа 1", new List<double> {3.0}));

            while(studentStack.Count > 0)
            {
                Student student = studentStack.Pop();
                if (student.AverageGrade() >= 4.0)
                {
                    Console.WriteLine($"Студент: {student.Name}, Группа: {student.Group}, Средний балл: {student.AverageGrade()}");
                }
            }
        }
    }
}
