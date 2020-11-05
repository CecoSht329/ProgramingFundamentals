using System;

namespace ForeachLOOP
{
    class ForeachLOOP
    {
        static void Main(string[] args)
        {
            string[] texts = Console.ReadLine().Split();

            foreach (string current in texts)//this is the same 
            {
                Console.WriteLine(current);
            }
            Console.WriteLine();
            for (int i = 0; i < texts.Length; i++)//as this 
            {
                string current = texts[i];

                Console.WriteLine(current);
            }
        }
    }
}
