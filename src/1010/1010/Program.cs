using System;
using System.Globalization;

namespace _1010
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int codigo1, codigo2, qtd1, qtd2;
            double preco1, preco2, total;

            string[] valores = Console.ReadLine().Split(' ');
            codigo1 = int.Parse(valores[0]);
            qtd1 = int.Parse(valores[1]);
            preco1 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            valores = Console.ReadLine().Split(' ');
            codigo2 = int.Parse(valores[0]);
            qtd2 = int.Parse(valores[1]);
            preco2 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            total = preco1 * qtd1 + preco2 * qtd2;

            Console.WriteLine($"VALOR A PAGAR: R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
