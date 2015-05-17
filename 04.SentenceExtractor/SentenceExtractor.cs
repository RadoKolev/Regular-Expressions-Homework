using System;
using System.Text.RegularExpressions;

class SentenceExtractor
{
    static void Main()
    {
        Console.WriteLine("Please enter the keyword:");
        string keyword = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("Please enter your text:");
        string text = Console.ReadLine();
        Console.WriteLine();
        
        string pattern = @"\b[^.?!]+\b" + keyword + @"\b.*?[!.?]";
        Regex regex = new Regex(pattern);

        MatchCollection matches = Regex.Matches(text, pattern);
        Console.WriteLine("The sentence(s) from the text, containing the keyword:");
        foreach (Match match in matches)
        {
            Console.WriteLine(match);
        }
    }
}