using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        string entrada = Console.ReadLine();
        string[] valores = entrada.Split(' ');
        double A = double.Parse(valores[0], CultureInfo.InvariantCulture);
        double B = double.Parse(valores[1], CultureInfo.InvariantCulture);
        double C = double.Parse(valores[2], CultureInfo.InvariantCulture);
        double pi = 3.14159;

        double triangulo = (A * C) / 2;
        System.Console.WriteLine($"TRIANGULO: {triangulo.ToString("F3", CultureInfo.InvariantCulture)}");
        double circulo = pi * Math.Pow(C, 2);
        System.Console.WriteLine($"CIRCULO: {circulo.ToString("F3", CultureInfo.InvariantCulture)}");
        double trapezio = ((A + B) * C) / 2;
        System.Console.WriteLine($"TRAPEZIO: {trapezio.ToString("F3", CultureInfo.InvariantCulture)}");
        double quadrado = Math.Pow(B, 2);
        System.Console.WriteLine($"QUADRADO: {quadrado.ToString("F3", CultureInfo.InvariantCulture)}");
        double retangulo = A * B;
        System.Console.WriteLine($"RETANGULO: {retangulo.ToString("F3", CultureInfo.InvariantCulture)}");

    }
}