using System;


class Program
{
    static void Main()
    {
        int width = int.Parse(Console.ReadLine());
        int heigth = int.Parse(Console.ReadLine());
        int area = GetRectangleArea(width, heigth);
        Console.WriteLine(area);
    }
    static int GetRectangleArea(int width,int heigth)
    {
        return width * heigth;
    }
}

