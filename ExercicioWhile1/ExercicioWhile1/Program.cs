﻿using System;

namespace ExercicioWhile1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite sua senha: ");
            int senha = int.Parse(Console.ReadLine());

            while (senha !=  2002)
            {
                Console.WriteLine("senha invalida");
                Console.Write("Digite sua senha: ");
                senha = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso permitido");
        }
    }
}
