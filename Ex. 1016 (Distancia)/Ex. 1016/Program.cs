using System;
using System.Globalization;

class URI {

    static void Main(string[] args)
    {
        int distancia = int.Parse(Console.ReadLine().ToString(), CultureInfo.InvariantCulture);
        int tempo = distancia * 2;
        System.Console.WriteLine($"{tempo} minutos");
    }
}