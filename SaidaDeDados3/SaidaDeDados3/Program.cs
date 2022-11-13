using System;
using System.Globalization;

namespace SaidaDeDados3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Qual o seu nome completo? ");
            string nomeCompleto = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa? ");
            int quarto = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Infome seu ultimo nome, idade e altura: ");
            string [] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine("Seu último nome é: " + nome);
            Console.WriteLine("Sua idade: " + idade);
            Console.WriteLine("Sua altura é: " + altura.ToString("F2", CultureInfo.InvariantCulture));
            

        }
    }
}
