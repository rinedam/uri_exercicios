using System; 

class URI {

    static void Main(string[] args)
    {

        int n = int.Parse(Console.ReadLine());
        int horas = n / 3600;
        int minutos = (n % 3600) / 60;
        int segundos = n % 60;

        Console.WriteLine($"{horas}:{minutos:D1}:{segundos:D1}");
    }

}