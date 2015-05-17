using System;
using System.Text.RegularExpressions;

class ExtractEmails
{
    static void Main()
    {
        Console.WriteLine("Please enter your text:");
        string text = Console.ReadLine();
        Console.WriteLine();

        string pattern = @"(\w*[-._]*\w+)([-.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";
        Regex regex = new Regex(pattern);

        MatchCollection matches = Regex.Matches(text, pattern);
        Console.WriteLine("Email(s) in your text:");
        foreach (Match match in matches)
        {
            Console.WriteLine(match);
        }
    }
}