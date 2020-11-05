using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        // The tricky part here is the Swap command;
        List<string> shelfWithBooks = Console.ReadLine().Split("&", StringSplitOptions.RemoveEmptyEntries).ToList();

        string input;

        while ((input = Console.ReadLine()) != "Done")
        {
            string[] inputCommand = input.Split(" | ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            string command = inputCommand[0];
            string bookName;
            switch (command)
            {
                case "Add Book":
                    bookName = inputCommand[1];
                    if (!shelfWithBooks.Contains(bookName))
                    {
                        shelfWithBooks.Insert(0, bookName);
                    }
                    break;
                case "Take Book":
                    bookName = inputCommand[1];
                    if (shelfWithBooks.Contains(bookName))
                    {
                        shelfWithBooks.Remove(bookName);
                    }
                    break;
                case "Swap Books":
                    string book1 = inputCommand[1];
                    string book2 = inputCommand[2];

                    if (shelfWithBooks.Contains(book1) && shelfWithBooks.Contains(book2))
                    {
                        int indexOfBook1 = shelfWithBooks.IndexOf(book1);
                        int indexOfBook2 = shelfWithBooks.IndexOf(book2);
                        string temp1 = shelfWithBooks[indexOfBook1];
                        string temp2 = shelfWithBooks[indexOfBook2];
                        shelfWithBooks[indexOfBook1] = temp2;
                        shelfWithBooks[indexOfBook2] = temp1;
                    }
                    break;
                case "Insert Book":
                    bookName = inputCommand[1];
                    shelfWithBooks.Add(bookName);
                    break;
                case "Check Book":
                    int index = int.Parse(inputCommand[1]);
                    if (index >= 0 && index < shelfWithBooks.Count)
                    {
                        Console.WriteLine(shelfWithBooks[index]);
                    }
                    break;
            }
        }
        Console.WriteLine(string.Join(", ", shelfWithBooks));
    }
}