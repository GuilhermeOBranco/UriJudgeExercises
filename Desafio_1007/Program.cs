﻿using System;

namespace Desafio_1007
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            int D = int.Parse(Console.ReadLine());

            int DIFERENCA = ((A * B) - (C * D));

            System.Console.WriteLine("DIFERENCA = {0}", DIFERENCA);
        }
    }
}
