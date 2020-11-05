using System;

namespace _5._Decrypting_Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int numberOfLines = int.Parse(Console.ReadLine());

            string word = string.Empty;
            for (int i = 0; i < numberOfLines; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                int actualLetter = (int)(letter) + key;
                word += (char)(actualLetter);
            }
            Console.WriteLine(word);
        }
    }
}
