﻿using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        string nomeVendedor = Console.ReadLine();
        double salarioFixo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double totalVendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double comissao = totalVendas * 0.15;
        double salarioTotal = salarioFixo + comissao;
        Console.WriteLine($"TOTAL = R$ {salarioTotal.ToString("F2", CultureInfo.InvariantCulture)}");
    }
}