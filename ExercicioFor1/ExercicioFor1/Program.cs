using System;

namespace ExercicioFor1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número:");
            int x = int.Parse(Console.ReadLine());

            for (int i = 1; i <= x; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
