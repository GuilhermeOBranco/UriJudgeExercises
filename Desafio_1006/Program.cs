using System;

namespace Desafio_1006
{
    class Program
    {
        static void Main(string[] args)
        {
            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());
            double C = double.Parse(Console.ReadLine());

            double media = ((0.20 * A) + (0.30 * B) + (0.50 * C) / (0.20 + 0.30 + 0.50));
            System.Console.WriteLine("MEDIA = {0:F1}", media);
        }
    }
}
