using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static string logFile = "app.log";

    static void Main()
    {
        List<int> grades = new List<int>();

        LogMessage("Application started");

        Console.WriteLine("Simple Grade Manager");
        Console.WriteLine("Enter grades. Type -1 to finish.");

        while (true)
        {
            Console.Write("Enter grade: ");

            int input = int.Parse(Console.ReadLine());

            if (input == -1)
                break;

            grades.Add(input);

            LogMessage($"Grade entered: {input}");
        }

        Console.WriteLine("\nGrades entered:");

        foreach (var g in grades)
        {
            Console.WriteLine($"- {g}");
        }

        double avg = CalculateAverage(grades);

        LogMessage($"Average calculated: {avg:F2}");

        Console.WriteLine($"\nAverage grade: {avg:F2}");

        LogMessage("Application finished");
    }

    static double CalculateAverage(List<int> grades)
    {
        int sum = 0;

        foreach (var g in grades)
        {
            sum += g;
        }

        return grades.Count > 0 ? (double)sum / grades.Count : 0;
    }

    static void LogMessage(string message)
    {
        File.AppendAllText(
            "app.log",
            $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - {message}{Environment.NewLine}"
        );
    }
}