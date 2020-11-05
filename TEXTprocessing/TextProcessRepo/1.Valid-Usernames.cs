using System;


class Program
{
    static void Main()
    {
        string[] names = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

        PrintResult(names);
    }

    private static void PrintResult(string[] names)
    {
        for (int i = 0; i < names.Length; i++)
        {
            if (CheckIfNameValid(names, i) /*== true*/)
            {
                Console.WriteLine(names[i]);
            }
        }
    }

    private static bool CheckIfNameValid(string[] names, int i)
    {
        string currentName = names[i];
        if (currentName.Length < 3 || currentName.Length > 16)
        {
            return false;
        }
        for (int j = 0; j < currentName.Length; j++)
        {
            char currentChar = currentName[j];
            if (!(char.IsLetterOrDigit(currentChar) || currentChar == '-' || currentChar == '_'))
            {
                return false;
            }
        }
        return true;
    }
}
