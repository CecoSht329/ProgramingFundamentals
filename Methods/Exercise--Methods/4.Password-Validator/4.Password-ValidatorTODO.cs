using System;


class Program
{
    static void Main()
    {
        string password = Console.ReadLine();
        bool paswordIsCorrect = IsPasswordCorrect(password);
        bool areLettersAndDigits = AreSymbolsValid(password);
        bool containsAtLeastTwoDigits = ContainsTwoDigits(password);

        PrintResult(paswordIsCorrect, areLettersAndDigits, containsAtLeastTwoDigits);
    }

    private static void PrintResult(bool paswordIsCorrect, bool areLettersAndDigits, bool containsAtLeastTwoDigits)
    {
        if (!paswordIsCorrect)
        {
            Console.WriteLine("Password must be between 6 and 10 characters");
        }
        if (!areLettersAndDigits)
        {
            Console.WriteLine("Password must consist only of letters and digits");
        }
        if (!containsAtLeastTwoDigits)
        {
            Console.WriteLine("Password must have at least 2 digits");
        }
        if (paswordIsCorrect && areLettersAndDigits && containsAtLeastTwoDigits)
        {
            Console.WriteLine("Password is valid");
        }
    }

    static bool ContainsTwoDigits(string password)
    {
        int counter = 0;
        for (int i = 0; i < password.Length; i++)
        {

            if (char.IsDigit(password[i]))
            {
                counter++;
                if (counter == 2)
                {
                    return true;
                }
            }
        }
        return false;
    }

    static bool AreSymbolsValid(string password)
    {
        for (int i = 0; i < password.Length; i++)
        {

            if (!char.IsLetterOrDigit(password[i]))
            {
                return false;
            }
        }
        return true;
    }

    static bool IsPasswordCorrect(string password)
    {
        if (password.Length >= 6 && password.Length <= 10)
        {
            return true;
        }
        return false;
    }
}

