﻿using System;
using System.Globalization;

class URI {
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(' ');
        int A = int.Parse(input[0]);
        int B = int.Parse(input[1]);
        int C = int.Parse(input[2]);
        int D = int.Parse(input[3]);

        if (B > C && D > A && (C + D) > (A + B) && C > 0 && D > 0 && A % 2 == 0)
        {
            System.Console.WriteLine("Valores aceitos");
        }
        else
        {
            System.Console.WriteLine("Valores nao aceitos");
        }
    }
}