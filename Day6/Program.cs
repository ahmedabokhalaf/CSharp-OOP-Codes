using System;

namespace Day6
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Shape (Inheritance)
            //Console.Write("Enter the Shape you want: ");
            //string shape = Console.ReadLine();
            //switch (shape.ToLower())
            //{
            //    case "square":
            //        Square s = new Square();
            //        Console.Write("Enter the length of side for the Square: ");
            //        Console.WriteLine("The Area is: "+s.CalcArea(double.Parse(Console.ReadLine())));
            //        break;
            //    case "rectangle":
            //        Rectangle r = new Rectangle();
            //        Console.WriteLine("Enter the Dimensions for the Rectangle: ");
            //        Console.WriteLine("The Area is: " + r.CalcArea(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine())));
            //        break;
            //    case "circle":
            //        Circle c = new Circle();
            //        Console.Write("Enter the radius for the Circle: ");
            //        Console.WriteLine("The Area is: " + c.CalcArea(double.Parse(Console.ReadLine())));
            //        break;
            //    default:break;
            //}
            #endregion

            #region Picture (Composition, Aggregation, and Assocciation)
            //Console.Write("Enter the length of side for the Square: ");
            //double dim = double.Parse(Console.ReadLine());
            //Square s1 = new Square(dim);
            //Console.WriteLine("Area = " + s1.CalcArea(s1.Dimension));

            //Picture pic = new Picture();
            //pic.sqr = s1;
            //Square s = pic.sqr;
            //Console.WriteLine("Area After Composition = " + pic.sqr.CalcArea(s.Dimension));

            //Console.WriteLine("=============================\nEnter the Dimensions for the Rectangle");
            //Rectangle r = new Rectangle();
            //Console.Write("Width of Rectangle: ");
            //r.Dimension = double.Parse(Console.ReadLine());
            //Console.Write("Height of Rectangle: ");
            //r.Dimension2 = double.Parse(Console.ReadLine());
            //pic.rect = r;
            //Console.WriteLine("Area After Aggregation = " + pic.rect.CalcArea(r.Dimension,r.Dimension2));
            //Console.WriteLine($"Total Area = {pic.CalcTotalArea()}");

            //Console.Write ("=============================\nEnter the radius for the Circle to Calculate Circle Area : ");
            //Circle circle = new Circle();
            //circle.Dimension = double.Parse(Console.ReadLine());
            //Console.WriteLine("The Area is: " + pic.CalcCirArea(circle));
            #endregion

            #region Picture By Array
            //Console.Write("Number of Squares?? ");
            //int numSquares = int.Parse(Console.ReadLine());
            //Console.Write("Number of Rectangles?? ");
            //int numRectangles = int.Parse(Console.ReadLine());
            //Picture pic = new Picture(numSquares, numRectangles);
            //for (int i = 0; i < pic.Squares.Length; i++)
            //{
            //    pic.Squares[i] = new Square();
            //}
            //for (int i = 0; i < pic.Rectangles.Length; i++)
            //{
            //    pic.Rectangles[i] = new Rectangle();
            //}
            //Square[] squares = pic.Squares;
            //Rectangle[] rectangles = pic.Rectangles;
            //for (int i = 0; i < squares.Length; i++)
            //{
            //    Console.Write($"Enter the length of side for the Square #{i + 1}: ");
            //    squares[i].Dimension = double.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("===============================================");
            //for (int i = 0; i < rectangles.Length; i++)
            //{
            //    Console.WriteLine($"Enter the Dimensions for the Rectangle #{i + 1}");
            //    Console.Write("Width: ");
            //    rectangles[i].Dimension = double.Parse(Console.ReadLine());
            //    Console.Write("Height: ");
            //    rectangles[i].Dimension2 = double.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("===============================================");
            //Console.Write("Enter the radius for the Circle to Calculate Circle Area : ");
            //Circle circle = new Circle();
            //circle.Dimension = double.Parse(Console.ReadLine());
            //Console.WriteLine("Area of Circle is: " + pic.CalcCirArea(circle));
            //Console.WriteLine($"\n***************************************\n" +
            //    $"Total Area of Picture is: {pic.CalcTotalArea()}\n***************************************");
            #endregion
        }
    }
}
