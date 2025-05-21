﻿using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        double A, B, C, media;

        // Lê os valores de A e B
        A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        media = ((A * 2) + (B * 3) + (C * 5)) / 10;
        Console.WriteLine($"MEDIA = {media:F1}");

    }
}