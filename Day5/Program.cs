using System;

namespace Day5
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Fraction
            //Fraction fraction1 = new Fraction();
            //string[] fraction = new string[2];
            //Console.Write("Enter 1st Fraction: ");
            //fraction = Console.ReadLine().Split('/');
            //fraction1.Numerator = double.Parse(fraction[0]);
            //fraction1.Denominator = double.Parse(fraction[1]);

            //Fraction fraction2 = new Fraction();
            //Console.Write("Enter 2nd Fraction: ");
            //fraction = Console.ReadLine().Split('/');
            //fraction2.Numerator = double.Parse(fraction[0]);
            //fraction2.Denominator = double.Parse(fraction[1]);

            //Fraction fraction3 = fraction1 + fraction2;
            //Console.WriteLine(fraction3.Print());
            //fraction3++;
            //Console.WriteLine($"After Increment : {fraction3.Print()}");

            //if (fraction1 == fraction2)
            //{
            //    Console.WriteLine($"{fraction1.Print()} and {fraction2.Print()} are Equals");
            //}
            //else
            //{
            //    Console.WriteLine($"{fraction1.Print()} and {fraction2.Print()} are not Equals");
            //}
            #endregion

            #region Department
            Console.Write("Enter Number of Emplyees in Department: ");
            int size = int.Parse(Console.ReadLine());
            Department dept1 = new Department(size);
            for (int i = 0; i < dept1.Employees.Length; i++)
            {
                Console.Write("Enter Name of Emplyee: ");
                dept1.Employees[i] = Console.ReadLine();
            }
            Console.Write("Enter Number of Emplyees in New Department: ");
            size = int.Parse(Console.ReadLine());
            Department newDept = dept1.ShallowCopy(size);
            Console.WriteLine("The New Department After Shallow Copy is: ");
            newDept.Print();
            newDept = dept1.DeepCopy(size);
            Console.WriteLine("The New Department After Deep Copy is: ");
            newDept.Print();
            newDept.Employees[3] = "Mahmoud";
            Console.WriteLine(newDept.Employees[3]);
            Console.WriteLine(dept1.Employees[3]);
            #endregion
            Console.ReadKey();
        }
    }
}
