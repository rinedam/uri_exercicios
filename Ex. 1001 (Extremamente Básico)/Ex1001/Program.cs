using System;

public class Program
{
    public static void Main(string[] args)
    {
        int a, b;

        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());

        int x = a + b;
        Console.WriteLine($"X = {x}");
    }
}