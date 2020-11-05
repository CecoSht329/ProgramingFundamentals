using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, List<string>> courseAndStudents = new Dictionary<string, List<string>>();

        string input;
        while ((input = Console.ReadLine()) != "end")
        {
            string[] courseAndStudentName = input.Split(" : ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            string course = courseAndStudentName[0];
            string student = courseAndStudentName[1];

            if (!courseAndStudents.ContainsKey(course))
            {
                courseAndStudents[course] = new List<string>();
            }
            courseAndStudents[course].Add(student);
        }
        Dictionary<string, List<string>> filtered = courseAndStudents
                .OrderByDescending(kvp => kvp.Value.Count)
                .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
        foreach (var kvp in filtered)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value.Count}");
            kvp.Value.Sort();
            for (int i = 0; i < kvp.Value.Count; i++)
            {
                Console.WriteLine($"-- {kvp.Value[i]}");
            }
        }
    }

}
