using System;
using System.Globalization;

namespace _1008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int funcionario, hora;
            double salario, salarioHora;

            funcionario = int.Parse(Console.ReadLine());
            hora = int.Parse(Console.ReadLine());
            salarioHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salario = hora * salarioHora;

            Console.WriteLine($"NUMBER = {funcionario}");
            Console.WriteLine($"SALARY = U$ {salario.ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}
