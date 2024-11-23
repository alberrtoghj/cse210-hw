using System;
using System.Collections.Generic;
using System.Linq;

public class Reference
{
    public string Book {get; private set; }
    public string ChapterVerse { get; private set; }

    public Reference(string book, string chapterVerse)
    {
        Book = book;
        ChapterVerse = chapterVerse;
    }

    public override string ToString()
    {
        return $"{Book} {ChapterVerse}";
    }
}

public class Word
{
    public string Text { get; private set; }
    public bool IsHidden { get; private set; }

    public Word(string text)
    {
        Text = text;
        IsHidden = false;
    }

    public void Hide()
    {
        IsHidden = true;
    }

    public override string ToString()
    {
        return IsHidden ? new string('_', Text.Length) : Text;
    }
}

public class Scripture
{
    public Reference Reference { get; private set; }
    private List<Word> Words;
    private static readonly Random random = new Random();

    public Scripture(Reference reference, string text)
    {
        Reference = reference;
        Words = text.Split(' ')
                    .Where(word => !string.IsNullOrWhiteSpace(word))
                    .Select(word => new Word(word.Trim(new char[] { '.', ',', ';', '!' })))
                    .ToList();
        
    }
    public void HideRandomWords(int count)
    {
        var visibleWords = Words.Where(word => !word.IsHidden). ToList();

        for (int i = 0; i < count && visibleWords.Count > 0; i++)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }

    public bool IsFullyHidden()
    {
        return Words.All(word => word.IsHidden);
    }
    public override string ToString()
    {
        return $"*** {Reference} ***\n\n{string.Join(' ', Words)}\n";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Scripture Memorization Program!");
        Console.WriteLine("The goal is to memorize the scripture as words are hidden");
        Console.WriteLine("Press Enter to hide words or type 'quit' to exit at any time. \n");

        var reference = new Reference("John", "3:16");
        var scripture = new Scripture(reference, "For God so loved the world that He gave His only begotten Son");

        RunScriptureProgram(scripture);
    }

    static void RunScriptureProgram(Scripture scripture)
    {
        while(true)
        {
            Console.Clear();
            Console.WriteLine(scripture);

            if (scripture.IsFullyHidden())
            {
                Console.WriteLine("\nAll words are hidden. Well done!");
                break;
            }

            Console.WriteLine("\nPress Enter to hide words, or type 'quit' to exit. ");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                Console.WriteLine("Goodbye!");
                break;
            }

            scripture.HideRandomWords(3);
        }
    }
}