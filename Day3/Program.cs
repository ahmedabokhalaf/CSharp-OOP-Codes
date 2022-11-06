using System;

namespace Day3
{
    class Program
    {
        static void Add(int[,] DegreesOfStudents, int value, ref int indxOfStudent, ref int indxOfDegree)
        {
            if (indxOfStudent <= DegreesOfStudents.Length - 1)
            {
                DegreesOfStudents[indxOfStudent, indxOfDegree] = value;
                indxOfDegree++;
            }
        }
        static void Edit(int[,] DegreesOfStudents, int value, int placeOfStudent, int placeOfDegree)
        {
            if (placeOfStudent <= DegreesOfStudents.Length && placeOfDegree<=10)
            {
                DegreesOfStudents[placeOfStudent - 1, placeOfDegree - 1] = value;
            }
        }
        static void Display(int[,] DegreesOfStudents, ref int indxOfStudent, ref int indxOfDegree)
        {
            for(int i = 0; i < indxOfStudent+1; i++)
            {
                Console.WriteLine($"This is Degrees of Student#{i+1}:");
                for (int j = 0; j < indxOfDegree; j++)
                {
                    Console.Write(DegreesOfStudents[i, j] + "\t");
                }
                Console.WriteLine("\n===========================================");
            }
        }
        static void Delete(int[,] DegreesOfStudents, int placeOfStudent, int placeOfDegree, ref int indxOfDegree)
        {
            if (placeOfStudent <= DegreesOfStudents.Length && placeOfDegree <= 10)
            {
                for(int i = placeOfDegree - 1; i < indxOfDegree - 1; i++)
                {
                    DegreesOfStudents[placeOfStudent - 1, i] = DegreesOfStudents[placeOfStudent - 1, i + 1];
                }
            }
            indxOfDegree--;
        }

        static void Main(string[] args)
        {
            #region 1DArray
            //int n = 0;
            //int[] degrees = new int[10];
            //int value = 0;
            //int indx = 0;
            //int placeOfEdit = 0;
            //do
            //{
            //    Console.WriteLine("================================================\n" +
            //        "Check From The Menu\n1.Add\n2.Edit\n3.Display\n4.Delete\n5.Exit");
            //    n = int.Parse(Console.ReadLine());
            //    switch (n)
            //    {
            //        case 1:
            //            {
            //                Console.Write("Add Degree: ");
            //                value = int.Parse(Console.ReadLine());
            //                Add(degrees, value, ref indx);
            //                break;
            //            }
            //        case 2:
            //            {
            //                Console.Write("Enter a New Degree: ");
            //                value = int.Parse(Console.ReadLine());
            //                Console.Write("Enter the place where you want to add the new degree: ");
            //                placeOfEdit = int.Parse(Console.ReadLine());
            //                Edit(degrees, value, placeOfEdit);
            //                break;
            //            }
            //        case 3:
            //            {
            //                Console.WriteLine("Your Array Became:");
            //                Display(degrees, ref indx);
            //                break;
            //            }
            //        case 4:
            //            {
            //                Console.Write("Enter the Deleting place: ");
            //                placeOfEdit = int.Parse(Console.ReadLine());
            //                Delete(degrees, placeOfEdit, ref indx);
            //                break;
            //            }
            //        case 5:
            //            break;
            //    }
            //} while (n < 5); 
            #endregion

            Console.Write("Enter Number of Students: ");
            int NumOfStudents = int.Parse(Console.ReadLine());
            int[,] DegreesOfStudents = new int[NumOfStudents, 10];
            int indxOfStudent = 0;
            int indxOfDegree = 0;
            int n = 0;
            int value = 0;
            int placeOfStudent = 0;
            int placeOfDegree = 0;
            do
            {
                Console.WriteLine("================================================\n" +
                    "Check From The Menu\n1.Add\n2.Edit\n3.Display\n4.Delete\n5.Exit");
                n = int.Parse(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        {
                            Console.Write($"Enter a Student #{indxOfStudent+1} Degree: ");
                            value = int.Parse(Console.ReadLine());
                            Add(DegreesOfStudents, value, ref indxOfStudent, ref indxOfDegree);
                            break;
                        }
                    case 2:
                        {
                            Console.Write($"Enter a New Degree : ");
                            value = int.Parse(Console.ReadLine());
                            Console.Write("Enter the place where you want to add the new degree: ");
                            placeOfDegree = int.Parse(Console.ReadLine());
                            Console.Write("Enter the Student Number: ");
                            placeOfStudent = int.Parse(Console.ReadLine());
                            Edit(DegreesOfStudents, value, placeOfStudent, placeOfDegree);
                            break;
                        }
                    case 3:
                        {
                            Display(DegreesOfStudents, ref indxOfStudent, ref indxOfDegree);
                            break;
                        }
                    case 4:
                        {
                            Console.Write("Enter the Student Number : ");
                            placeOfStudent = int.Parse(Console.ReadLine());
                            Console.Write("Enter the Deleting Place : ");
                            placeOfDegree = int.Parse(Console.ReadLine());
                            Delete(DegreesOfStudents, placeOfStudent, placeOfDegree, ref indxOfDegree);
                            break;
                        }
                    case 5:
                        break;
                }
            } while (n < 5);
        }
    }
}
