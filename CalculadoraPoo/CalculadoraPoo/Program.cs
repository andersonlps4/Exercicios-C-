using System;
using System.Globalization;

namespace CalculadoraPoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Calculo.Circunferencia(raio);
            double volume = Calculo.Volume(raio);

            Console.WriteLine("Circunferencia: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + Calculo.Pi.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
