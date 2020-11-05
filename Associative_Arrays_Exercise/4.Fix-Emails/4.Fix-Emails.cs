using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, string> nameAndEmail = new Dictionary<string, string>();
        string name = string.Empty;
        string email = string.Empty;
        int counter = 0;
        string input;
        while ((input = Console.ReadLine()) != "stop")
        {
            counter++;
            if (counter % 2 != 0)
            {
                name = input;
            }
            else
            {
                email = input;
                if (!nameAndEmail.ContainsKey(name))
                {
                    nameAndEmail[name] = string.Empty;
                    nameAndEmail[name] = email;
                }
            }
        }
        foreach (var kvp in nameAndEmail)
        {
            if (kvp.Value.EndsWith("uk") || kvp.Value.EndsWith("us"))
            {
                nameAndEmail.Remove(kvp.Key);
                nameAndEmail.Remove(kvp.Value);
            }
            else
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }

            //for (int i = kvp.Value.Length - 1; i >= 0; i--)
            //{
            //    if ((kvp.Value[i] == 's' || kvp.Value[i] == 'k') && kvp.Value[i - 1] == 'u')
            //    {
            //        nameAndEmail.Remove(kvp.Key);
            //        nameAndEmail.Remove(kvp.Value);
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            //        break;
            //    }
            //}
        }
    }
}

