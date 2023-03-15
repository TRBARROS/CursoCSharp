using EX03;
using System;
using System.IO;

namespace EX02
{
    class Program
    {
        static void Main(string[] args)
        {
            string maisVelha;

            Pessoa p1, p2;
            p1 = new Pessoa();
            p2 = new Pessoa();

            Console.WriteLine("Digite o nome da primeira pessoa:");
            p1.nome = Console.ReadLine();
            Console.WriteLine("Digite a idade da primeira pessoa");
            p1.idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o nome da segunda pessoa:");
            p2.nome = Console.ReadLine();
            Console.WriteLine("Digite a idade da segunda pessoa");
            p2.idade = Convert.ToInt32(Console.ReadLine());

            if (p1.idade > p2.idade)
            {
                maisVelha = p1.nome;
            }
            else if (p2.idade > p1.idade)
            {
                maisVelha = p2.nome;
            }
            else
            {
                maisVelha = "Ambas as pessoas tem a mesma idade";
            }

            Console.WriteLine("Dados da primeira pessoa:");
            Console.WriteLine($"Nome: {p1.nome}");
            Console.WriteLine($"Idade: {p1.idade}");
            Console.WriteLine($"Dados da segunda pessoa:");
            Console.WriteLine($"Nome: {p2.nome}");
            Console.WriteLine($"Idade: {p2.idade}");

            Console.WriteLine($"Pessoa mais velha: {maisVelha}");
        }
    }
}