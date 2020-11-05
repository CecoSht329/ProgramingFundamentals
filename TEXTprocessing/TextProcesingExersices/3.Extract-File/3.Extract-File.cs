using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // input: C:\Internal\training-internal\Template.pptx
        string path = Console.ReadLine();

        string[] pathArgs = path.Split('\\', StringSplitOptions.RemoveEmptyEntries).ToArray();

        string[] fileInfo = pathArgs.Last()
            .Split(".", StringSplitOptions.RemoveEmptyEntries);
        string[] fileNameArgs = fileInfo.Take(fileInfo.Length - 1).ToArray();

        string fileName = string.Join(".", fileNameArgs);

        string fileExtention = fileInfo.Last();

        Console.WriteLine($"File name: {fileName}");
        Console.WriteLine($"File extension: {fileExtention}");
        // output: File name: Template
        // File extension: pptx
    }
}

