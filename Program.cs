using System;

namespace ShapeDrawingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;

            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. Draw the triangle");
                Console.WriteLine("2. Draw the square");
                Console.WriteLine("3. Draw the rectangle");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        DrawTriangle();
                        break;
                    case 2:
                        DrawSquare();
                        break;
                    case 3:
                        DrawRectangle();
                        break;
                    case 4:
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }

                Console.WriteLine();
            } while (choice != 4);
        }

        static void DrawTriangle()
        {
            Console.WriteLine("  *  ");
            Console.WriteLine(" *** ");
            Console.WriteLine("*****");
        }

        static void DrawSquare()
        {
            Console.WriteLine("*****");
            Console.WriteLine("*****");
            Console.WriteLine("*****");
            Console.WriteLine("*****");
            Console.WriteLine("*****");
        }

        static void DrawRectangle()
        {
            Console.WriteLine("******");
            Console.WriteLine("******");
            Console.WriteLine("******");
            Console.WriteLine("******");
        }
    }
}
