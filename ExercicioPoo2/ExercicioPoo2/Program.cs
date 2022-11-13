using System;
using System.Globalization;

namespace ExercicioPoo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Fazer um programa para ler nome e salário de dois funcionários. Depois, mostrar o salário médio dos funcionários.*/
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            p1.Nome = Console.ReadLine();
            Console.Write("Salario: ");
            p1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário:");
            Console.Write("Nome: ");
            p2.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            p2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (p1.Salario + p2.Salario) / 2;

            Console.WriteLine("Salário médio = " + media.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
