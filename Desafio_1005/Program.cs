using System;

namespace Desafio_1005
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            
            double PesoMedia1 = 0.3181818181818182;
            double PesoMedia2 = 0.6818181818181818;

            double media = ((PesoMedia1 * a) + (PesoMedia2 * b ) / (PesoMedia1 + PesoMedia2));
            System.Console.WriteLine("MEDIA = {0:F5}",media);
        }
    }
}
