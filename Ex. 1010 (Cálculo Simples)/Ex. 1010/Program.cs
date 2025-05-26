using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        string entrada1 = Console.ReadLine();
        string[] valores1 = entrada1.Split(' ');
        int codigoPeca1 = int.Parse(valores1[0]);
        int numeroPecas1 = int.Parse(valores1[1]);
        double precoPeca1 = double.Parse(valores1[2], CultureInfo.InvariantCulture);

        string entrada2 = Console.ReadLine();
        string[] valores2 = entrada2.Split(' ');
        int codigoPeca2 = int.Parse(valores2[0]);
        int numeroPecas2 = int.Parse(valores2[1]);
        double precoPeca2 = double.Parse(valores2[2], CultureInfo.InvariantCulture);

        double totalPagar = (numeroPecas1 * precoPeca1) + (numeroPecas2 * precoPeca2);
        Console.WriteLine($"VALOR A PAGAR: R$ {totalPagar.ToString("F2", CultureInfo.InvariantCulture)}");

    }
}