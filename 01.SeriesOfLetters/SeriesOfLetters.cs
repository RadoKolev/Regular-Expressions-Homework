using System;
using System.Text.RegularExpressions;

class SeriesOfLetters
{
    static void Main()
    {
        Console.WriteLine("Please enter your text:");
        string inputText = Console.ReadLine();

        Regex regex = new Regex(@"([a-zA-Z])\1{0,}");
        MatchCollection matches = regex.Matches(inputText);
        string outputText = null;

        for (int i = 0; i < matches.Count; i++)
        {
            outputText += matches[i].ToString().Substring(0, 1);
        }
        Console.WriteLine();
        Console.WriteLine("Your text without consecutive identical letters: " + outputText);
    }
}