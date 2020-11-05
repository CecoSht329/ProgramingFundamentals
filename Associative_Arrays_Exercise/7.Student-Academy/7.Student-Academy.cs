using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

class Program
{
    static void Main()
    {
        int pairs = int.Parse(Console.ReadLine());

        Dictionary<string, List<double>> studentsAndGrades = new Dictionary<string, List<double>>();

        for (int i = 0; i < pairs; i++)
        {
            string name = Console.ReadLine();
            double grade = double.Parse(Console.ReadLine());
            if (!studentsAndGrades.ContainsKey(name))
            {
                studentsAndGrades[name] = new List<double>();
            }
            studentsAndGrades[name].Add(grade);
        }
        Dictionary<string, double> averageGradePerStudent = new Dictionary<string, double>();
        foreach (var kvp in studentsAndGrades)
        {
            if (!averageGradePerStudent.ContainsKey(kvp.Key))
            {
                averageGradePerStudent[kvp.Key] = kvp.Value.Sum() / kvp.Value.Count;
            }
        }
        var filtered = averageGradePerStudent.OrderByDescending(kvp => kvp.Value)
            .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
        foreach (var kvp in filtered)
        {
            if (kvp.Value >= 4.5)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value:f2}");
            }
            else
            {
                break;
            }
        }
    }
}

