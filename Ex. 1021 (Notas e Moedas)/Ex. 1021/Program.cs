using System;
using System.Globalization;

class URI {
    static void Main(string[] args)
    {
        double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        int centavos = (int)(valor * 100);

        int notas100 = centavos / 10000;
        centavos %= 10000;
        int notas50 = centavos / 5000;
        centavos %= 5000;
        int notas20 = centavos / 2000;
        centavos %= 2000;
        int notas10 = centavos / 1000;
        centavos %= 1000;
        int notas5 = centavos / 500;
        centavos %= 500;
        int notas2 = centavos / 200;
        centavos %= 200;
        
        int moedas1 = centavos / 100;
        centavos %= 100;
        int moedas050 = centavos / 50;
        centavos %= 50;
        int moedas025 = centavos / 25;
        centavos %= 25;
        int moedas010 = centavos / 10;
        centavos %= 10;
        int moedas005 = centavos / 5;
        centavos %= 5;
        int moedas001 = centavos;

        Console.WriteLine("NOTAS:");
        Console.WriteLine(notas100 + " nota(s) de R$ 100.00");
        Console.WriteLine(notas50 + " nota(s) de R$ 50.00");
        Console.WriteLine(notas20 + " nota(s) de R$ 20.00");
        Console.WriteLine(notas10 + " nota(s) de R$ 10.00");
        Console.WriteLine(notas5 + " nota(s) de R$ 5.00");
        Console.WriteLine(notas2 + " nota(s) de R$ 2.00");
        Console.WriteLine("MOEDAS:");
        Console.WriteLine(moedas1 + " moeda(s) de R$ 1.00");
        Console.WriteLine(moedas050 + " moeda(s) de R$ 0.50");
        Console.WriteLine(moedas025 + " moeda(s) de R$ 0.25");
        Console.WriteLine(moedas010 + " moeda(s) de R$ 0.10");
        Console.WriteLine(moedas005 + " moeda(s) de R$ 0.05");
        Console.WriteLine(moedas001 + " moeda(s) de R$ 0.01");
    }
}