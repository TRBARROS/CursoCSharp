using System;
using System.IO;

namespace EX02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome:");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa ?");
            int numQuartos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto:");
            double preco = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Entre com seu ultimo nome, idade e altura (mesma linha):");
            string[] unai = Console.ReadLine().Split(' ');
            Console.WriteLine(nome);
            Console.WriteLine(numQuartos);
            Console.WriteLine(preco);
            Console.WriteLine(unai[0]);
            Console.WriteLine(unai[1]);
            Console.WriteLine(unai[2]);
        }
    }
}