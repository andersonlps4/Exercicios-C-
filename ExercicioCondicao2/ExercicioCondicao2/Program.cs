﻿using System;

namespace ExercicioCondicao2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro");
            int numero = int.Parse(Console.ReadLine());

            if(numero % 2 == 0)
            {
                Console.WriteLine("Par");
            } else {

                Console.WriteLine("Ímpar");
            }
        }
    }
}
