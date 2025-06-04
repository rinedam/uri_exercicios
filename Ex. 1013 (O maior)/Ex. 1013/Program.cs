using System; 

class URI {

    static void Main(string[] args)
    {
        // URI Online Judge | 1013
        // O maior
        int a, b, c, maiorAB;
        string[] valores = Console.ReadLine().Split(' ');
        a = int.Parse(valores[0]);
        b = int.Parse(valores[1]);
        c = int.Parse(valores[2]);

        maiorAB = (a + b + Math.Abs(a - b)) / 2;
        if (maiorAB < c)
        {
            maiorAB = c;
        }
        System.Console.WriteLine(maiorAB + " eh o maior");
    }

}