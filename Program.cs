using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> grades = new List<int>();
        Console.WriteLine("Simple Grade Manager");
        Console.WriteLine("Enter grades. Type -1 to finish.");

        while (true)
        {
            Console.Write("Enter grade: ");
            int input = int.Parse(Console.ReadLine());

            if (input == -1) break;
            grades.Add(input);
        }

        Console.WriteLine("\nGrades entered:");
        foreach (var g in grades)
            Console.WriteLine($"- {g}");

        double avg = CalculateAverage(grades);
        Console.WriteLine($"\nAverage grade: {avg:F2}");
    }

    static double CalculateAverage(List<int> grades)
    {
        int sum = 0;
        foreach (var g in grades)
            sum += g;

        return grades.Count > 0 ? (double)sum / grades.Count : 0;
    }
}

