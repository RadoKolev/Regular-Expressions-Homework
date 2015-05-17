using System;
using System.Text.RegularExpressions;

class ReplaceTag
{
    static void Main()
    {
        Console.WriteLine("Please enter your string on a single line:");
        string inputString = Console.ReadLine();
        Console.WriteLine();

        string pattern = @"<a href=([^>]+)>([^<]+)</a>";
        string replacement = "[URL href=$1]$2[/URL]";

        Regex regex = new Regex(pattern);
        string outputString = regex.Replace(inputString, replacement);

        Console.WriteLine("Your replaced string is:");
        Console.WriteLine(outputString);
    }
}