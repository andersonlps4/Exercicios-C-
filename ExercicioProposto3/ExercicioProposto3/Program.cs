using System;

namespace ExercicioProposto3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, dif;

            Console.Write("Digite o primeiro número: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Digite o terceiro número: ");
            c = int.Parse(Console.ReadLine());
            Console.Write("Digite o quarto número: ");
            d = int.Parse(Console.ReadLine());

            dif = a * b - c * b;

            Console.WriteLine("A diferença é: " + dif);
        }
    }
}
