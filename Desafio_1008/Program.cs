using System;

namespace Desafio_1008
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroFuncionario = int.Parse(Console.ReadLine());
            int horasTrabalhadas = int.Parse(Console.ReadLine());
            double valorPorHora = double.Parse(Console.ReadLine());

            System.Console.WriteLine("NUMBER = {0} \nSALARY = U$ {1:F2}", numeroFuncionario, (horasTrabalhadas * valorPorHora));
        }
    }
}
