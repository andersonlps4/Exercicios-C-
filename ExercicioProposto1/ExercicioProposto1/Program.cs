using System;

namespace ExercicioProposto1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, soma;

            Console.Write("Digite o primeiro número: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            b = int.Parse(Console.ReadLine());

            soma = a + b;

            Console.WriteLine("A soma é: " + soma);
        }
    }
}
