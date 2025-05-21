using System;

public class Program
{
    public static void Main(string[] args)
    {
        double pi = 3.14159;
        double r = double.Parse(Console.ReadLine());
        double area = pi * Math.Pow(r, 2);
        Console.WriteLine($"A={area:F4}");
    }
}