using System;

namespace MoodAnalyserProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nWelcome to Mood Analyzer");
            Console.WriteLine("\nEnter Your Current Mood : ");
            string message = Console.ReadLine();
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer(message); //Creating a object of MooddAnalyzer class
            string mood = moodAnalyzer.AnalyzeMood(); // calling method of class with paasing user message as parameter
            Console.WriteLine($"\nYou are in \"{mood}\" Mood");
        }
    }
}
