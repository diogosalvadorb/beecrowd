using System;

namespace _1013
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, z, maiorxy, maior;

            string[] valores = Console.ReadLine().Split(' ');
            x = int.Parse(valores[0]);
            y = int.Parse(valores[1]);
            z = int.Parse(valores[2]);

            maiorxy = (x + y + Math.Abs(x - y)) / 2;

            maior = (maiorxy + z + Math.Abs(maiorxy - z)) / 2;

            Console.WriteLine($"{maior} eh o maior");
        }
    }
}
