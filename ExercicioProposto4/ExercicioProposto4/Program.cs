using System;
using System.Globalization;

namespace ExercicioProposto4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Num_func, Hora_trabalhada;
            double Valor_hora, salario;
            

            Console.Write("Infome o seu número de funcionário: ");
            Num_func =  int.Parse(Console.ReadLine());
            Console.Write("Infome quantas horas trabalhou: ");
            Hora_trabalhada = int.Parse(Console.ReadLine());
            Console.Write("Informe o valor da sua hora trabalhada: ");
            Valor_hora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            

            salario = Hora_trabalhada * Valor_hora;

            Console.WriteLine("Número do funcionário: " + Num_func);
            Console.WriteLine("O seu sálario é: " + salario.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
