﻿using System;
using System.Globalization;

namespace _1002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14159, raio, area;

            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            area = pi * raio * raio;

            Console.WriteLine($"A = {area.ToString("F4", CultureInfo.InvariantCulture)}");
        }
    }
}
