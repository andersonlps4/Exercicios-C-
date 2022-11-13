using System;

namespace ExercicioCondicao3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string [] vetores = Console.ReadLine().Split(' ');
            int num1 = int.Parse(vetores[0]);
            int num2 = int.Parse(vetores[1]);

            if(num1 % num2 == 0 || num2 % num1 == 0)
            {
                Console.WriteLine("São múltiplos");
            } else {

                Console.WriteLine("Não são múltiplos");
            }
        }

    }
}
