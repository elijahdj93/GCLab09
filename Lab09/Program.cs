using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepGoing = true;
            while (keepGoing == true)
            {
                Circle CircleTester = new Circle();

                Console.WriteLine("Welcome to the circle tester!");
                Console.WriteLine();
                Console.WriteLine("Enter radius:");
                CircleTester.Radius = ReadValidNumbers();
                if (CircleTester.Radius < 0)
                {
                    Console.WriteLine("Please enter valid number.");

                }
                else
                {
                    CircleTester.GetCircumference();
                    CircleTester.GetArea();
                }

                string userChoice;
                Console.WriteLine("Continue? (y/n)");
                userChoice = Console.ReadLine();
                if (userChoice == "n" || userChoice == "N")
                {
                    keepGoing = false;
                }
            }
        }

        public static double ReadValidNumbers()
        {
            double Input = 0;

            while (!double.TryParse(Console.ReadLine(), out Input))
            {

                Console.WriteLine("Please enter a number!");
            }
            // after the while, you will have a valid number! 
            return Input;



        }
    }
}
