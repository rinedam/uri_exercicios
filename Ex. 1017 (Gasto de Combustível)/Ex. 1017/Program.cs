using System; 

class URI {

    static void Main(string[] args)
    {

        int tempoViagem = int.Parse(Console.ReadLine());
        int velocidadeMedia = int.Parse(Console.ReadLine());

        double combustivelGasto = tempoViagem * velocidadeMedia / 12.0;
        Console.WriteLine($"{combustivelGasto:F3}", System.Globalization.CultureInfo.InvariantCulture);

    }

}