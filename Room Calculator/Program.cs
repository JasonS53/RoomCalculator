using System;

namespace Room_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
        start:
            //This program is to determine area, perimiter and volume of two classrooms and how much paint and carpet is needed
            Console.WriteLine("Welcome to the Grand Circus Room Detail Generator");
            Console.WriteLine("Which is the length of the room you would like to calculate?");
            double length = double.Parse(Console.ReadLine());

            Console.WriteLine("What is the width of the room you would like to calculate?");
            double width = double.Parse(Console.ReadLine());

            Console.WriteLine("What is the height of the room you would like to calculate?");
            double height = double.Parse(Console.ReadLine());

            double area = (length * width);
            double perimeter = ((length * 2) + (width * 2));

            double carpet = (area / 5);
            double paint = ((perimeter * height) / 5);
            double volume = (length * width * height);

            Console.WriteLine($"Length: { length }");
            Console.WriteLine($"Width: { width }");
            Console.WriteLine($"Area: { area }");
            Console.WriteLine($"Perimiter { perimeter}");
            Console.WriteLine($"Carpet squares needed: { carpet }");
            Console.WriteLine($"Paint cans needed: { paint }");
            Console.WriteLine($"Total room volume: { volume }");

            query:

            { 
            Console.WriteLine("Would you like to do another calculation?");
            string yesno = Console.ReadLine();

                if (yesno == "yes")
                {
                    goto start;
                }

                if (yesno == "no")
                {
                    Console.WriteLine("Thank you for participating.  Have a good day");
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("I'm sorry, I didn't understand.");
                    goto query;
                }
            }
                         
            


        }
    }
}
