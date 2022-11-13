using System;
using System.Globalization;

namespace ExercicioCondicao4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("| Código      Produto       Preço |");
            Console.WriteLine("|    1    Cachorro quente    4,00 |");
            Console.WriteLine("|    2       X-Salada        4,50 |");
            Console.WriteLine("|    3       X-Bacon         5,00 |");
            Console.WriteLine("|    4    Torrada simples    2,00 |");
            Console.WriteLine("|    5    Cachorro quente    1,50 |");
            Console.WriteLine("-----------------------------------");

            Console.WriteLine("Digite o codigo e a quantidade desejada!");

            string [] vet = Console.ReadLine().Split(' ');
            int codigo = int.Parse(vet[0]);
            int quantidade = int.Parse(vet[1]);

            double total;

            if(codigo == 1)
            {
                total = quantidade * 4.00;

            } else if (codigo ==2){

                total = quantidade * 5.50;

            } else if (codigo == 3){

                total = quantidade * 5.00;

            }else if (codigo == 4){

                total = quantidade * 2.00;

            }else
            {
                total = quantidade * 1.50;
            }
            Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
        
    
    }
}
