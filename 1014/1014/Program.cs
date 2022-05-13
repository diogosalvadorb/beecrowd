using System;
using System.Globalization;

namespace _1014
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int km;
            double litroGasolina, consumo;

            km = int.Parse(Console.ReadLine());
            litroGasolina = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            consumo = km / litroGasolina;

            Console.WriteLine($"{consumo.ToString("F3", CultureInfo.InvariantCulture)} km/l");
        }
    }
}
