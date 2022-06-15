using System;

namespace _1016
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tempo, distancia;

            distancia = int.Parse(Console.ReadLine());

            tempo = distancia * 2;

            Console.WriteLine($"{tempo} minutos");
        }
    }
}
