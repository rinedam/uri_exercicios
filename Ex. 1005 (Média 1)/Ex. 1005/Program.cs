using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        double A, B, media;

        // Lê os valores de A e B
        A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        // Nota a tem peso 3.5 e b tem peso 7.5
        media = ((A * 3.5) + (B * 7.5)) / 11;
        Console.WriteLine($"MEDIA = {media:F5}");

    }
}