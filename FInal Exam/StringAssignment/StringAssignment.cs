using System;


class StringAssignment
{
    static void Main()
    {
        string message = Console.ReadLine();
        string commandInput = "";
        while ((commandInput = Console.ReadLine()) != "Decode")
        {
            string[] tokens = commandInput.Split("|", StringSplitOptions.RemoveEmptyEntries);
            string command = tokens[0];
            if (command == "Move")
            {
                int numberOfLetters = int.Parse(tokens[1]);
                string substring = message.Substring(0, numberOfLetters);
                if (message.Contains(substring))
                {
                    message = message.Replace(substring, "");
                    message = message + substring;
                }
            }
            else if (command == "Insert")
            {
                int index = int.Parse(tokens[1]);
                string value = tokens[2];
                message = message.Insert(index, value);
            }
            else if (command == "ChangeAll")
            {
                string substring = tokens[1];
                string replacement = tokens[2];
                if (message.Contains(substring))
                {
                    message = message.Replace(substring, replacement);
                }
            }
        }
        Console.WriteLine($"The decrypted message is: {message}");
    }
}

