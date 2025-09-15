
// 2, 4, 5
namespace Second
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Instructor instructor = new Instructor("Ahmed", 29);
            var student1 = new Student("Ali", 22);
            var student2 = new Student("Tamer", 23);
            var course = new Course("C#");
            instructor.TeachCourse(course);
            course.students.Add(student1);
            course.students.Add(student2);
            Console.WriteLine($"MR: {course.teacher.Name} theaching in course: {course.Name}");
            Console.WriteLine("For students: ");
            foreach (var student in course.students)
                Console.WriteLine($"\t {student.Name}");

            student1.ID = IdGenerator.GenerateId();
            student2.ID = IdGenerator.GenerateId();

            var grade1 = new Grade(50);
            var grade2 = new Grade(70);

            student1.grades.Add(grade1);
            student1.grades.Add(grade2);

            int total = grade1 + grade2;
        }

    }
    public abstract class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public Person(String name, int age)
        {
            Name = name;
            Age = age;
        }

        public abstract void Introduce();
    }
    public class Instructor : Person
    {
        public int ID { get; set; }
        public Instructor(string name, int age) : base(name, age) { }

        public override void Introduce()
        {
            Console.WriteLine($"Instructor: {Name}");
        }

        public void TeachCourse(Course course)
        {
            course.teacher = this;
        }
    }
    public class Student : Person
    {
        public int ID { get; set; }
        public int courseLevel { get; set; }

        public List<Grade> grades = new List<Grade>();
        public Student(string name, int age) : base(name, age) { }

        public override void Introduce()
        {
            Console.WriteLine($"Student: {Name}");
        }

        public void RegisterCourse(Course course)
        {
            course.students.Add(this);
            switch (courseLevel)
            {

                case 0:
                    Console.WriteLine("Good luck");
                    break;
                case 2:
                    Console.WriteLine("This will be challenging");
                    break;
            }

        }
    }
    public class Course
    {
        public string Name { get; set; }
        public Instructor teacher;
        public List<Student> students;
        public Course(string name)
        {
            Name = name;
            students = new List<Student>();
        }
    }

    public class Grade
    {
        public int Value { get; set; }
        public Grade(int value)
        {
            Value = value;
        }

        public static int operator +(Grade grade1, Grade grade2)
        {
            return grade1.Value + grade2.Value;
        }
        public static bool operator ==(Grade grade1, Grade grade2)
        {
            return grade1.Value == grade2.Value;
        }
        public static bool operator !=(Grade grade1, Grade grade2)
        {
            return grade1.Value != grade2.Value;
        }
    }

    public class IdGenerator
    {
        public static int id = 1;
        public static int GenerateId()
        {
            return id++;
        }
    }

    public enum CourseLevel
    {
        Beginner,
        Intermediate,
        Advanced
    };
}
