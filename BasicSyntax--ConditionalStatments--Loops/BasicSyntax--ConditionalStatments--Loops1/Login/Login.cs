using System;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = "";
            for (int i = username.Length - 1; i >= 0; i--)
            {
                password += username[i];
            }
            for (int j = 0; j < 3; j++)
            {
                string input = Console.ReadLine();
                if (input == password)
                {
                    Console.WriteLine($"User {username} logged in.");
                    return;
                }
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
            }
            string lastTry = Console.ReadLine();
            if (password == lastTry)
            {
                Console.WriteLine($"User {username} logged in.");
            }
            else
            {
                Console.WriteLine($"User {username} blocked!");
            }
        }
    }
}
