using System;
using System.Globalization;

namespace ExercicioRetanguloPoo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo ret = new Retangulo();

            Console.WriteLine("Entre com a largura e altura do retângulo");
            ret.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            ret.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Area = " + ret.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Perimetro = "+ ret.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal = " + ret.Perimetro().ToString("F2", CultureInfo.InvariantCulture));

            
        }
    }
}
