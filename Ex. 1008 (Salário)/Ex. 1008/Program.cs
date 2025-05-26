using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        int numeroFuncionario = int.Parse(Console.ReadLine());
        double horasTrabalhadas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double salario = horasTrabalhadas * valorPorHora;
        Console.WriteLine($"NUMBER = {numeroFuncionario}");
        Console.WriteLine($"SALARY = U$ {salario.ToString("F2", CultureInfo.InvariantCulture)}");

    }
}