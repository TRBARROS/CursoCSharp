using System;
using System.Globalization;

namespace EX07
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno Aluno1 = new Aluno();

            Console.WriteLine("Digite o nome do aluno:");
            Aluno1.Name = Console.ReadLine();
            Console.WriteLine("Digite a primeira nota:");
            Aluno1.Nota1 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite a segunda nota:");
            Aluno1.Nota2 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite a terceira nota:");
            Aluno1.Nota3 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Nome do aluno: {Aluno1.Name}");
            Console.WriteLine("Digite as três notas do aluno");
            Console.WriteLine(Aluno1.Nota1.ToString("F02", CultureInfo.InvariantCulture));
            Console.WriteLine(Aluno1.Nota2.ToString("F02", CultureInfo.InvariantCulture));
            Console.WriteLine(Aluno1.Nota3.ToString("F02", CultureInfo.InvariantCulture));
            Console.WriteLine($"NOTA FINAL = {Aluno1.SomaNotas().ToString("F02", CultureInfo.InvariantCulture)}");

            if (Aluno1.SomaNotas() < 60.00)
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine($"FALTARAM {Aluno1.Diferenca().ToString("F02", CultureInfo.InvariantCulture)} PONTOS");
            }
            else
            {
                Console.WriteLine("APROVADO");
            }
        }
    }
}