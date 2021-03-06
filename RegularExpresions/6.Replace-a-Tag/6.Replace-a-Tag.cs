﻿using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();

        while (!input.Equals("end"))
        {
            Regex regex = new Regex("(\\s*)<a href=\"(.*?)\">(.*?)<\\/a>(\\s*)");

            input = regex.Replace(input, "$1[URL href=$2]$3[URL]$4");
            Console.WriteLine(input);

            input = Console.ReadLine();
        }
    }
}

