using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AoC2015.Days;

namespace AoC2015
{
    class Program
    {
        static void Main(string[] args)
        {
            var stillRunning = true;

            while (stillRunning)
            {
                // The code provided will print ‘Hello World’ to the console.
                // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
                Console.WriteLine("Which day would you like to run? : ");
                var dayChoice = Console.ReadLine();

                switch (dayChoice)
                {
                    case "1":
                        Day1 day1 = new Day1();
                        day1.Run();
                        break;
                    case "2":
                        Day2 day2 = new Day2();
                        day2.Run();
                        break;
                    default:
                        Console.WriteLine("That is an invalid entry, please enter a number between 1-25");
                        break;
                }

                Console.WriteLine("Go again? (y | n)");
                var goAgain = Console.ReadLine();
                
                if (goAgain.ToString().ToLower() == "n")
                {
                    stillRunning = false;
                }

                // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
            }
        }
    }
}
