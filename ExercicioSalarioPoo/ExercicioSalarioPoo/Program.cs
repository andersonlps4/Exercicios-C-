using System;
using System.Globalization;

namespace ExercicioSalarioPoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario func = new Funcionario();

            Console.WriteLine("Informe os dados do funcionario");
            Console.Write("Nome: ");
            func.Nome = Console.ReadLine();
            Console.Write("Salario bruto: ");
            func.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            func.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine();
            Console.WriteLine("Funcionário: " + func);

            Console.WriteLine();
            Console.WriteLine("Deseja aumentar o salário em qual porcentagem?");
            //informei o tipo da variável, e nomeei ela, e o usuário informou o valor que ela iria receber         
            double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //chamei a função que tem o calculo de aumentar o salario, e pegou o valor que o usuário digitou na variável anterior
            func.AumentarSalario(porcent);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + func);
        }
    }
}
