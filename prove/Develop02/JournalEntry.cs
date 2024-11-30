using System;

public class JournalEntry
{
    public string Prompt { get; set; }
    public string Response { get; set; }
    public string Date { get; set; }

    public JournalEntry(string prompt, string response)
    {
        Prompt = prompt;
        Response = response;
        Date = DateTime.Now.ToString("yyyyy-MM-dd");
    }

    public override string ToString()
    {
        return $"{Date} {Prompt} {Response}";
    }
}