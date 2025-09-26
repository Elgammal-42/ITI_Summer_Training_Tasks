namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // -1
            //First();

            // -2
            string[] names = { "Tom", "Dick", "Harry", "MARY", "Jay" };
            /*Second1(names);
            Second2(names);
            Second3(names);*/

            // -3
            List<Student> students = new List<Student>(){
                new Student(){ ID=1, FirstName="Ali", LastName="Mohammed", Subjects=new Subject[]
                    { new Subject(){ Code=22,Name="EF"}, new Subject(){ Code=33,Name="UML"}}},
                new Student(){ ID=2, FirstName="Mona", LastName="Gala", Subjects=new Subject []{ new Subject(){
                    Code=22,Name="EF"}, new Subject (){ Code=34,Name="XML"},new Subject (){ Code=25, Name="JS"}}}, new Student(){ ID=3, FirstName="Yara", LastName="Yousf", Subjects=new Subject []{ new Subject (){ Code=22,Name="EF"}, new Subject (){ Code=25,Name="JS"}}},
                new Student(){ ID=1, FirstName="Ali", LastName="Ali", Subjects=new Subject []{ new Subject (){
                    Code=33,Name="UML"}}},
                };
            /*Third1(students);
            Third2(students);*/
            Third3(students);

        }

        private static void Third3(List<Student> students)
        {
            var Q3 = students.SelectMany(x => x.Subjects, (Stud, Sub) => new
            {
                FullName = Stud.FirstName + " " + Stud.LastName,
                sub = Sub.Name
            });
            foreach (var x in Q3)
                Console.WriteLine($"FullName = {x.FullName}, Sub = {x.sub}");

            Console.WriteLine();
            Console.WriteLine("using group by");
            Console.WriteLine();

            var Q4 = Q3.GroupBy(x => x.FullName);
            foreach (var x in Q4)
            {
                Console.WriteLine($"{x.Key}: ");
                foreach (var y in x)
                    Console.WriteLine($"    {y.sub}");
            }
        }

        private static void Third2(List<Student> students)
        {
            var Q2 = students.OrderByDescending(x => x.FirstName).ThenBy(x => x.LastName)
                                .Select(x => new { FullName = x.FirstName + " " + x.LastName });
            foreach (var student in Q2)
                Console.WriteLine(student.FullName);
        }

        private static void Third1(List<Student> students)
        {
            var Q1 = students.Select(x => new { FullName = x.FirstName + " " + x.LastName, Subs = x.Subjects.Length });
            foreach (var x in Q1)
            {
                Console.WriteLine($"FullName = {x.FullName}, NoOfSubs = {x.Subs}");
            }
        }

        private static void Second3(string[] names)
        {
            var two = names.Take(2);
            foreach (var name in two)
                Console.WriteLine(name);
            two = from name in names.Take(2) select name;
            foreach (var name in two)
                Console.WriteLine(name);
        }

        private static void Second2(string[] names)
        {
            var a = names.Where(x => x.ToLower().Contains("a")).OrderBy(x => x.Length);
            foreach (var name in a)
                Console.WriteLine(name);
            a = from x in names where x.ToLower().Contains("a") orderby x.Length select x;
            foreach (var name in a)
                Console.WriteLine(name);
        }

        private static void Second1(string[] names)
        {
            var len3 = names.Where(x => x.Length == 3);
            foreach (var i in len3)
            {
                Console.WriteLine(i);
            }
            len3 = from x in names where x.Length == 3 select x;
            foreach (var i in len3)
            {
                Console.WriteLine(i);
            }
        }

        private static void First()
        {
            List<int> numbers = new List<int>() { 2, 4, 6, 7, 1, 4, 2, 9, 1 };
            numbers.Sort();
            var list = numbers.Distinct();
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }

            foreach (int i in list)
            {
                Console.WriteLine($"< number: {i}, multiply: {i * i} >");
            }
        }

    }
}
