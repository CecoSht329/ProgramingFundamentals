using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Dictionary<string, List<string>> companyAndEmployeeID = new Dictionary<string, List<string>>();

        string input;
        
        while ((input = Console.ReadLine()) != "End")
        {
            string[] commandInput = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
            string company = commandInput[0];
            string employeeID = commandInput[1];
            if (!companyAndEmployeeID.ContainsKey(company))
            {
                companyAndEmployeeID[company] = new List<string>();
            }
            if (!companyAndEmployeeID[company].Contains(employeeID))
            {
                companyAndEmployeeID[company].Add(employeeID);
            }
            
        }
        var filtered = companyAndEmployeeID.OrderBy(kvp => kvp.Key).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
        foreach (var kvp in filtered)
        {
            Console.WriteLine(kvp.Key);
            for (int i = 0; i < kvp.Value.Count; i++)
            {
                Console.WriteLine($"-- {kvp.Value[i]}");
            }
        }
    }
}

