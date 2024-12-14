using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ActivityProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Activity> activities = new Dictionary<string, Activity>
            {
                { "1", new BreathingActivity() },
                { "2", new ReflectionActivity() },
                { "3", new ListingActivity() }
            };

            while (true)
            {
                Console.WriteLine("\nChoose an activity:");
                Console.WriteLine("1. Breathing Activity");
                Console.WriteLine("2. Reflection Activity");
                Console.WriteLine("3. Listing Activity");
                Console.WriteLine("4. Quit");

                string choice = Console.ReadLine();
                if (choice == "4")
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }

                if (activities.ContainsKey(choice))
                {
                    activities[choice].Run();
                }

                else
                {
                    Console.WriteLine("Invalid choice. Please try again");
                }
            }
        }
    }
}