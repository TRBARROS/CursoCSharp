using System;
using System.Globalization;

namespace EX04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double mediaSalarial;
            Funcionario f1, f2;
            f1 = new Funcionario();
            f2 = new Funcionario();

            Console.WriteLine("Digite o nome do primeiro funcionario:");
            f1.nome = Console.ReadLine();
            Console.WriteLine("Digite o salario do primeiro funcionario");
            f1.salario = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o nome do segundo funcionario:");
            f2.nome = Console.ReadLine();
            Console.WriteLine("Digite o salario do segundo funcionario");
            f2.salario = Convert.ToDouble(Console.ReadLine());

            mediaSalarial = (f1.salario + f2.salario) / 2;

            Console.WriteLine("Informações do primeiro funcionario:");
            Console.WriteLine($"Nome: {f1.nome}");
            Console.WriteLine($"Salario: {f1.salario.ToString("F02", CultureInfo.InvariantCulture)}");
            Console.WriteLine("Informações do segundo funcionario;");
            Console.WriteLine($"Nome: {f2.nome}");
            Console.WriteLine($"Salario: {f2.salario.ToString("F02", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Salário médio: {mediaSalarial.ToString("F02",CultureInfo.InvariantCulture)}");

        }
    }
}