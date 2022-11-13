﻿using System;
using System.Globalization;

namespace ExercicioProposto5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cod1, cod2, qte1, qte2;
            double preco1, preco2, total;

            Console.WriteLine("Informe o código, quantidade e valor do produto");
            string[] valores = Console.ReadLine().Split(' ');
            cod1 = int.Parse(valores[0]);
            qte1 = int.Parse(valores[1]);
            preco1 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            Console.WriteLine("Informe o código, quantidade e valor do produto");
            valores = Console.ReadLine().Split(' ');
            cod2 = int.Parse(valores[0]);
            qte2 = int.Parse(valores[1]);
            preco2 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            total = preco1 * qte1 + preco2 * qte2;

            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
