using System;

class Program
{
    static void Main(string[] args)
    {
           Random random = new Random();
           int magicNumber = random.Next(1, 101);

           Console.WriteLine("Welcome to the Guess My Number game!");
           Console.WriteLine("I have selected a magic number between 1 and 100.");
           Console.WriteLine("Try to guess it, and I will tell you if ou should guess hig or low.");

           int guess = -1;

           while (guess != magicNumber)
           {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}