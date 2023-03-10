using System;
using System.Globalization;

namespace EX01
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritorip";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1}, cujo preço é $ {preco1}");
            Console.WriteLine($"{produto2}, cujo preco é $ {preco2}");

            Console.WriteLine($"{idade} anos de idade, código {codigo} e gênero {genero}");

            Console.WriteLine($"Medida com oito casas decimais: {medida:F8}");
            Console.WriteLine($"Arredondado (três casas decimais): {medida:F03}");
            Console.WriteLine($"Separador decimal invariant culture: {medida.ToString("F03", CultureInfo.InvariantCulture)}");
        }
    }
}