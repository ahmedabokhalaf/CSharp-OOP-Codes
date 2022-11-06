using System;

namespace Day7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number of Squares?? ");
            int numSq = int.Parse(Console.ReadLine());

            Console.Write("Number of Rectangles?? ");
            int numRec = int.Parse(Console.ReadLine());

            Console.Write("Number of Circles?? ");
            int numCir = int.Parse(Console.ReadLine());

            Console.WriteLine($"So, This Picture Consists of {numCir + numRec + numSq} Shapes");
            Picture picture = new Picture(numCir + numRec + numSq);

            Console.WriteLine("============================================================");
            for (int i = 0; i < numSq; i++)
            {
                picture.Shapes[i] = new Square();
                Console.Write($"Enter The Length of Side for This Square: ");
                picture.Shapes[i].Dimension = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("============================================================");
            for (int i = numSq; i < numRec + numSq; i++)
            {
                picture.Shapes[i] = new Rectangle();
                Console.WriteLine($"Enter The 2 Dimension for This Rectangle");
                Console.Write("Width: ");
                picture.Shapes[i].Dimension = double.Parse(Console.ReadLine());
                Console.Write("Height: ");
                picture.Shapes[i].Dimension2 = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("============================================================");
            for (int i = numSq+numRec; i < numSq+numRec+numCir; i++) 
            {
                picture.Shapes[i] = new Circle();
                Console.Write($"Enter The Radius for This Circle: ");
                picture.Shapes[i].Dimension = double.Parse(Console.ReadLine());
            }
            Console.WriteLine($"\n***************************************\n" +
                $"Total Area of Picture is: {picture.CalcTotalArea()}\n***************************************");

            Console.ReadKey();
        }
    }
}
