using System;
using System.Diagnostics;

namespace ActivityProgram
{
    class BreathingActivity : Activity
    {
        public BreathingActivity() 
            : base("Breathing", "This activity will help you relax by guiding you through slow breathing. Clear your mind and focus on your breath")
        {
            
        }
        public override void Run()
        {
            DisplayStartingMessage();
            for (int i = 0; i < Duration / 6; i++)
            {
                Console.WriteLine("\nBreathe in...");
                ShowAnimation("...", 3);
                Console.WriteLine("Breathe out...");
                ShowAnimation("...", 3);
            }
            DisplayEndingMessage();
        }
    }
}