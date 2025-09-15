
namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company("MyCompany");

            var HrDept = new Department("HR");
            var SalesDept = new Department("Sales");
            var ItDept = new Department("IT");

            List<Department> departmentList = new List<Department>();
            departmentList.Add(HrDept);
            departmentList.Add(SalesDept);
            departmentList.Add(ItDept);

            company.departments = departmentList;

            var course1 = new Course("C#");
            var course2 = new Course("Java");

            var emp1 = new Employee("Ahmed");
            var emp2 = new Employee("Mohamed");
            var emp3 = new Employee("Ali");
            var emp4 = new Employee("Kamal");

            emp1.AddDepartment(HrDept);
            emp2.AddDepartment(SalesDept);
            emp3.AddDepartment(ItDept);
            emp4.AddDepartment(HrDept);

            emp1.courses.Add(course1);
            emp1.courses.Add(course2);
            emp2.courses.Add(course1);
            emp3.courses.Add(course2);
            emp4.courses.Add(course2);

            emp1.Info();
        }
    }
    public class Company
    {
        public List<Department> departments;
        public String Name { get; set; }
        public Company(string name)
        {
            Name = name;
            departments = new List<Department>();
        }
    }
    public class Department
    {
        public List<Employee> employees;
        public String Name { get; set; }
        public Department(string name)
        {
            Name = name;
            employees = new List<Employee>();
        }
    }
    public class Employee
    {
        public List<Course> courses;
        public Department department;
        public string Name { get; set; }
        public Employee(string name)
        {
            Name = name;
            courses = new List<Course>();
        }
        public void AddDepartment(Department department)
        {
            this.department = department;
        }
        public void Info()
        {
            Console.WriteLine($"Employee: {Name}");
            Console.WriteLine($"Department: {department.Name}");
            Console.WriteLine($"Courses:");
            foreach (Course course in courses)
            {
                Console.WriteLine($"\t{course.Name}");
            }

        }
    }
    public class Course
    {
        public List<Employee> employees;
        public string Name { get; set; }
        public Course(string name)
        {
            Name = name;
            employees = new List<Employee>();
        }
    }

    public class Car
    {
        public Engine engine;
        public string Model { get; set; }
    }
    public class Engine
    {
        public string Model { get; set; }
    }
}
