namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // First demand
            /*Console.WriteLine("How many students to store?");
            int n = int.Parse(Console.ReadLine());
            string[] names = new string[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter student{i + 1} name");
                names[i] = Console.ReadLine();
            }
            for (int i = 0; i < names.Length; i++)
                Console.WriteLine($"student{i+1} name: {names[i]}");*/

            // second demand
            /*Console.WriteLine("Enter how many tracks do you need");
            int tracksSize = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter how many students in each track");
            int studentsSize = int.Parse(Console.ReadLine());
            int[,] tracks = new int[tracksSize, studentsSize];
            float[] avgAgeInTracks = new float[tracksSize];
            for (int i = 0; i < tracksSize; i++)
            {
                int totalAge = 0;
                for (int j = 0; j < studentsSize; j++)
                {
                    Console.WriteLine($"For track number{i + 1} enter age for student{j + 1}");
                    int age = int.Parse(Console.ReadLine());
                    tracks[i, j] = age;
                    totalAge += age;
                }
                avgAgeInTracks[i] = (float)totalAge / studentsSize;
                Console.WriteLine();
            }
            for (int i = 0; i < tracksSize; i++)
            {
                Console.WriteLine($"AVG age in track{i + 1}: {avgAgeInTracks[i]} and students ages:");
                for (int j = 0; j < studentsSize; j++)
                {
                    Console.WriteLine($"student{j + 1}: {tracks[i, j]}");
                }
            }*/

            //Third demand
            /*int[,] time = new int[3, 1];
            time[0, 0] = 22;
            time[1, 0] = 33;
            time[2, 0] = 11;

            int hours = time[0, 0];
            int minutes = time[1, 0];
            int seconds = time[2, 0];
            Console.WriteLine($"{hours}H:{minutes}M:{seconds}S");*/



        }
    }
}
