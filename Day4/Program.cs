using System;

namespace Day4
{
    class Program
    {
        static void Main(string[] args)
        {
            Student std1 = new Student();
            Console.Write("Enter Name Of Student: ");
            string Name = Console.ReadLine();
            Console.Write($"Enter Age of {std1.Name}: ");
            int Age = int.Parse(Console.ReadLine());
            Console.Write($"Enter Number of Grades for {std1.Name}: ");
            int NumOfGrades = int.Parse(Console.ReadLine());
            int[] Grades = new int[NumOfGrades];
            Console.WriteLine("Enter Grades:");
            for (int i = 0; i < Grades.Length; i++)
                Grades[i] = int.Parse(Console.ReadLine());
            std1.SetGrades(Grades);
            std1.Print();
            Console.Write("Forget Your Password??? (Y/N): ");
            char ch = char.Parse(Console.ReadLine());
            if (ch.ToString().ToLower() == "y")
            {
                Console.Write("Enter Your Username: ");
                string username = Console.ReadLine();
                string msg = std1.ForgetPassword(username);
                Console.WriteLine(msg);
            }

            Student std = new Student();
            Console.Write("Enter Name Of Student: ");
            std.Name = Console.ReadLine();
            Console.Write($"Enter Age of {std.Name}: ");
            std.Age = int.Parse(Console.ReadLine());
            Console.Write($"Enter Number of Grades for {std.Name}: ");
            NumOfGrades = int.Parse(Console.ReadLine());
            Grades = new int[NumOfGrades];
            Console.WriteLine("Enter Grades:");
            for (int i = 0; i < Grades.Length; i++)
                Grades[i] = int.Parse(Console.ReadLine());
            std.SetGrades(Grades);
            std.Print();
            Console.Write("Forget Your Password??? (Y/N): ");
            ch = char.Parse(Console.ReadLine());
            if (ch.ToString().ToLower() == "y")
            {
                Console.Write("Enter Your Username: ");
                string username = Console.ReadLine();
                string msg = std.ForgetPassword(username);
                Console.WriteLine(msg);
            }
            Console.ReadKey();
        }
    }
}
