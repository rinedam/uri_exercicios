using System;
using System.Globalization;

class URI {

    static void Main(string[] args)
    {
        int x = int.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine().ToString(), CultureInfo.InvariantCulture);

        double consumo = x / y;
        Console.WriteLine($"{consumo.ToString("F3", CultureInfo.InvariantCulture)} km/l");
    }
}