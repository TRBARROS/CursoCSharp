using System;
using System.Globalization;

namespace EX08
{
    class Program
    {
        static void Main(string[] args)
        {
            double Cotacao;
            double Quantidade;
            double Resultado;

            Console.WriteLine("Qual é a cotação do dólar ?");
            Cotacao = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Quantos dólares você vai comprar ?");
            Quantidade = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            Resultado = ConversorDeMoeda.Calculo(Cotacao, Quantidade);

            Console.WriteLine($"Valor a ser pago em reais = {Resultado.ToString("F02", CultureInfo.InvariantCulture)}");
        }
    }
}