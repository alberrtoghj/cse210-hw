using System;

using System.Collections.Generic;
using System.Diagnostics;

namespace ActivityProgram
{
    class ListingActivity : Activity
    {
        private readonly List<string> Prompts;
        private int Duration = 60;

        public ListingActivity() 
            : base("Listing", "This activity will help you reflect on the good things in your life by listing as many items as you can in a certain area.")
        {
            Prompts = new List<string>
            {
                "Who are people that you appreciate?",
                "What are personal strengths of yours?",
                "Who are people that you have helped this week?",
                "When have you felt the Holy Ghost this month?",
                "Who are some of your personal heroes?"
            };
        }

        public override void Run()
        {
            DisplayStartingMessage();
            Random random = new Random();
            Console.WriteLine($"\n{Prompts[random.Next(Prompts.Count)]}");
            ShowAnimation("Get ready", 3);

            Console.WriteLine("\nStart listing items:");
            List<string> items = new List<string>();
            DateTime endTime = DateTime.Now.AddSeconds(Duration);

            while (DateTime.Now < endTime)
            {
                string item = Console.ReadLine();
                if (!string.IsNullOrEmpty(item))
                    items.Add(item);
            }

            Console.WriteLine($"\nYou listed {items.Count} items.");
            DisplayEndingMessage();
        }
    }
}