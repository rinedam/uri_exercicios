using System; 

class URI {

    static void Main(string[] args)
    {

        int n = int.Parse(Console.ReadLine());
        System.Console.WriteLine(n);
        int[] notas = { 100, 50, 20, 10, 5, 2, 1 };
        int[] quantidades = new int[7];

        for (int i = 0; i < notas.Length; i++)
        {
            quantidades[i] = n / notas[i];
            n %= notas[i];
        }

        Console.WriteLine(quantidades[0] + " nota(s) de R$ " + notas[0] + ",00");
        Console.WriteLine(quantidades[1] + " nota(s) de R$ " + notas[1] + ",00");
        Console.WriteLine(quantidades[2] + " nota(s) de R$ " + notas[2] + ",00");
        Console.WriteLine(quantidades[3] + " nota(s) de R$ " + notas[3] + ",00");
        Console.WriteLine(quantidades[4] + " nota(s) de R$ " + notas[4] + ",00");
        Console.WriteLine(quantidades[5] + " nota(s) de R$ " + notas[5] + ",00");
        Console.WriteLine(quantidades[6] + " nota(s) de R$ " + notas[6] + ",00");

    }

}