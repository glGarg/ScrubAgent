using ScrubberNamespace;
using System;

class Program
{
    static void Main(string[] args)
    {
        string testData = "Hello, my email is example@example.com and my friend's email is friend@example.net.";
        char replacementChar = '*';

        string scrubbedData = Scrubber.ScrubData(testData, replacementChar);
        Console.WriteLine("Original Data: " + testData);
        Console.WriteLine("Scrubbed Data: " + scrubbedData);
    }
}
