using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ActivityProgram
{
    class ReflectionActivity : Activity
    {
        private readonly List<string> Prompts;
        private readonly List<string> Questions;

        public ReflectionActivity() 
            : base("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience")
        {
            Prompts = new List<string>
            {
                 "Think of a time when you stood up for someone else.",
                "Think of a time when you did something really difficult.",
                "Think of a time when you helped someone in need.",
                "Think of a time when you did something truly selfless."
            };

            Questions = new List<string>
            {

                "Why was this experience meaningful to you?",
                "Have you ever done anything like this before?",
                "How did you get started?",
                "How did you feel when it was complete?",
                "What made this time different than other times when you were not as successful?",
                "What is your favorite thing about this experience?",
                "What could you learn from this experience that applies to other situations?",
                "What did you learn about yourself through this experience?",
                "How can you keep this experience in mind in the future?"
            };
        }

        public override void Run()
        {
            DisplayStartingMessage();
            Random random = new Random();
            Console.WriteLine($"\n{Prompts[random.Next(Prompts.Count)]}");
            ShowAnimation("Reflecting", 3);

            int timePerQuestion = Duration / Questions.Count;
            foreach(var question in Questions)
            {
                Console.WriteLine($"\n{question}");
                ShowAnimation("...", timePerQuestion);
            }

            DisplayEndingMessage();
        }
    }
}


using System;
using System.Collections.Generic;
using System.IO;

namespace GoalTracker
{
    // Base class for all goal types
    public abstract class Goal
    {
        public string Name { get; protected set; }
        public string Description { get; protected set; }
        public int Points { get; protected set; }
        public bool IsComplete { get; protected set; }
    }
}