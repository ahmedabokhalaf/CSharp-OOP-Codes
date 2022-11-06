using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //prob1
            //for (int i = 0; i <= 100; i++)
            //{
            //    if (i % 4 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            ///////////////////////////////////////////////////
            //prob2
            //Console.WriteLine("Enter the 10 numbers: ");
            //int mul = 1;
            //for (int i = 0; i < 10; i++)
            //{
            //    int num = int.Parse(Console.ReadLine());
            //    mul *= num;
            //}
            //Console.WriteLine($"The Result is {mul}");
            /////////////////////////////////////////////////
            //prob3
            //for (int i = 1; i <= 255; i++)
            //{
            //    Console.WriteLine($"The Charecter of {i} is\t: {Convert.ToChar(i)}");
            //}
            ////////////////////////////////
            //prob4
            //int total = 0;
            //int num = 0;
            //while (total <= 100)
            //{
            //    total += num;
            //    num = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine(total);
            //////////////////////////////////////
            //prob5
            //char ch = ' ';
            //do
            //{
            //    Console.Write("Enter a char: ");
            //    ch = char.Parse(Console.ReadLine());
            //    Console.WriteLine(Convert.ToInt32(ch));
            //} while (ch != 'x');
            ////////////////////////////////////////////
            //prob6
            //int num = 1;
            //Console.WriteLine("Menu: ");
            //do
            //{
            //    num = int.Parse(Console.ReadLine());
            //    switch (num)
            //    {
            //        case 1:
            //            Console.WriteLine("1.Add");
            //            break;
            //        case 2:
            //            Console.WriteLine("2.Edit");
            //            break;
            //        case 3:
            //            Console.WriteLine("3.Display");
            //            break;
            //        case 4:
            //            Console.WriteLine("4.Delete");
            //            break;
            //        default: break;
            //    }
            //} while (num <= 4);
            ///////////////////////////////////////////
            ///////////////////////////////////////////
            //prob1
            //Console.Write("Enter Number Of Student's Grades: ");
            //int size = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter The Grades Of Student: ");
            //double[] grades = new double[size];
            //double sum = 0, avg = 0;
            //for (int i = 0; i < grades.Length; i++)
            //{
            //    grades[i] = double.Parse(Console.ReadLine());
            //    sum += grades[i];
            //}
            //avg = sum / grades.Length;
            //if (avg >= 50)
            //{
            //    Console.WriteLine($"Your Result = {avg}, Success!");
            //}
            //else
            //{
            //    Console.WriteLine($"Your Result = {avg}, Fail");
            //}
            ////////////////////////////////////////////////////////////////
            //prob2
            //Console.Write("Enter number of rows: ");
            //int rows = int.Parse(Console.ReadLine());
            //Console.Write("Enter number of columns: ");
            //int columns = int.Parse(Console.ReadLine());

            //int[,] myArr = new int[rows, columns];
            //for (int i = 0; i < rows; i++)
            //{
            //    Console.WriteLine($"Enter Row #{i + 1}");
            //    for (int j = 0; j < columns; j++)
            //    {
            //        myArr[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //for (int j = 0; j < columns; j++)
            //{
            //    Console.Write($"The Column #{j + 1}: ");
            //    for (int i = 0; i < rows; i++)
            //    {
            //        Console.Write($"{myArr[i, j]}\t");
            //    }
            //    Console.WriteLine();
            //}
            //////////////////////////////////////////////////////
            //prob3
            //Console.Write("Enter number of Students: ");
            //int num_students = int.Parse(Console.ReadLine());
            //double[][] studentsGrades = new double[num_students][];
            //for (int student = 0; student < studentsGrades.Length; student++)
            //{
            //    Console.Write($"Enter Number of Grades for Student #{student + 1}: ");
            //    int num_grades = int.Parse(Console.ReadLine());
            //    studentsGrades[student] = new double[num_grades];
            //}

            //double sum = 0, avg = 0;
            //for (int student = 0; student < studentsGrades.Length; student++)
            //{
            //    sum = 0; avg = 0;
            //    Console.WriteLine($"==============================================" +
            //                        $"\nEnter The Grades Of Student #{student + 1}");
            //    for (int grade = 0; grade < studentsGrades[student].Length; grade++)
            //    {
            //        studentsGrades[student][grade] = double.Parse(Console.ReadLine());
            //        sum += studentsGrades[student][grade];
            //    }
            //    avg = sum / studentsGrades[student].Length;
            //    if (avg >= 50)
            //    {
            //        Console.WriteLine($"The Student #{student + 1} Result = {avg}, Success!");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"The Student #{student + 1} Result = {avg}, Fail");
            //    }
            //}
            /////////////////////////////////////////////////////////////////////////////////
            //prob4
            //Console.Write("Enter size of wanted array: ");
            //int size = int.Parse(Console.ReadLine());
            //int[] myarr = new int[size];
            //Console.WriteLine("Enter Elements of Your Array: ");
            //for (int i = 0; i < myarr.Length; i++)
            //{
            //    myarr[i] = int.Parse(Console.ReadLine());
            //}
            //Console.Write("Do you want to resize your array(Y/N)?: ");
            //char ch = char.Parse(Console.ReadLine());
            //if (ch.ToString().ToLower() == "y")
            //{
            //    Console.Write("Enter The New Size: ");
            //    int newsize = int.Parse(Console.ReadLine());

            //    if (newsize == size)
            //    {
            //        Console.WriteLine("This is Same Size of your Array!\nYour Array is: ");
            //        for (int i = 0; i < myarr.Length; i++)
            //        {
            //            Console.WriteLine($"{myarr[i]}\t");
            //        }
            //    }

            //    else if (newsize > size)
            //    {
            //        int[] newarr = new int[newsize];
            //        for (int i = 0; i < myarr.Length; i++)
            //        {
            //            newarr[i] = myarr[i];
            //        }
            //        Console.WriteLine($"You have {newarr.Length - myarr.Length} items left, please enter it");
            //        for (int i = myarr.Length; i < newarr.Length; i++)
            //        {
            //            newarr[i] = int.Parse(Console.ReadLine());
            //        }
            //        Console.WriteLine("Your Array has been changed to :");
            //        for (int i = 0; i < newarr.Length; i++)
            //        {
            //            Console.WriteLine($"{newarr[i]}\t");
            //        }
            //    }
            //    else
            //    {
            //        Console.Write("You can Delete one item Do you want to do this(Y/N)? : ");
            //        char ch2 = char.Parse(Console.ReadLine());
            //        if (ch.ToString().ToLower() == "y")
            //        {
            //            int[] newarr = new int[size - 1];
            //            Console.Write("Which item's index you want remove: ");
            //            int indx = int.Parse(Console.ReadLine());
            //            for (int i = indx - 1; i < myarr.Length - 1; i++)
            //            {
            //                myarr[i] = myarr[i + 1];
            //            }
            //            for (int i = 0; i < newarr.Length; i++)
            //            {
            //                newarr[i] = myarr[i];
            //            }
            //            Console.WriteLine("Your Array has been changed to :");
            //            for (int i = 0; i < newarr.Length; i++)
            //            {
            //                Console.WriteLine($"{newarr[i]}\t");
            //            }
            //        }
            //    }
            //}
            Console.ReadKey();
        }
    }
}
