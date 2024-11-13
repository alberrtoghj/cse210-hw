using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (true)
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());

            if (number == 0)
            {
                break;
            }
            numbers.Add(number);
        }

        int totalSum = 0;
        int maxNumber = int.MinValue;

        foreach (int num in numbers)
        {
            totalSum += num;
            if (num > maxNumber)
            {
                maxNumber = num;
            }
        }

        double average = numbers.Count > 0 ? (double)totalSum / numbers.Count : 0;

        Console.WriteLine($"The sum is: {totalSum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {maxNumber}");
    }
}
     