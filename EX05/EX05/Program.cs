using System;
using System.Globalization;

namespace EX05
{
    class Program
    {
        static void Main(string[] args)
        {
            double AreaRetangulo;
            double PerimetroRetangulo;
            double DiagonalRetangulo;

            Retangulo r1 = new Retangulo();
            
            Console.WriteLine("Entre com a largura do retangulo:");
            r1.Largura = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com a altura do retangulo:");
            r1.Altura = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            AreaRetangulo = r1.Area();
            PerimetroRetangulo = r1.Perimetro();
            DiagonalRetangulo = r1.Diagonal();

            Console.WriteLine("Entre a largura e altura do retângulo:");
            Console.WriteLine(r1.Largura.ToString("F02", CultureInfo.InvariantCulture));
            Console.WriteLine(r1.Altura.ToString("F02", CultureInfo.InvariantCulture));
            Console.WriteLine($"AREA = {AreaRetangulo.ToString("F02", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"PERÍMETRO = {PerimetroRetangulo.ToString("F02", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"DIAGONAL = {DiagonalRetangulo.ToString("F02", CultureInfo.InvariantCulture)}");
        }
    }
}