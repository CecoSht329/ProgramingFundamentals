using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<char, uint> histogram = new Dictionary<char, uint>();

        string text = Console.ReadLine();

        for (int i = 0; i < text.Length; i++)
        {
            char currentChar = text[i];
            if (currentChar != ' ')
            {
                if (!histogram.ContainsKey(currentChar))
                {
                    histogram[currentChar] = 0;
                    //histogram.Add(currentChar, 0);
                }
                histogram[currentChar]++;
            }
        }

        foreach (var keyValuePair in histogram)
        {
            Console.WriteLine(keyValuePair.Key + " -> " + keyValuePair.Value);
        }
    }

}
