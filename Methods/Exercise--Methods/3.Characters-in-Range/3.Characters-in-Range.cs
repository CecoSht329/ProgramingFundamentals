using System;


class CharactersInRange
{
    static void Main()
    {
        char firstChar = char.Parse(Console.ReadLine());
        char secondChar = char.Parse(Console.ReadLine());
        GetMedialCharacters(firstChar, secondChar);
    }
    static void GetMedialCharacters(char firstChar, char secondChar)
    {
        if (firstChar < secondChar)
        {
            for (int i = firstChar; i < secondChar - 1; i++)
            {
                char nextChar = (char)(i + 1);
                Console.Write((char)(i + 1) + " ");
            }
        }
        else if (firstChar > secondChar)
        {
            for (int i = secondChar; i < firstChar - 1; i++)
            {
                char nextChar = (char)(i + 1);
                Console.Write((char)(i + 1) + " ");
            }
        }

    }
}

