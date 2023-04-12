using System.Globalization;
using System.Collections.Generic;
using EX15.Entities;
using System;

namespace EX13
{
    class Program
    {
        static void Main(string[] args)
        {
            double SomaTotal = 0;
            Console.Write("Enter the number of tax payers: ");
            int QtdeTaxPay = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            List<Pessoa> Pessoas = new List<Pessoa>();

            for (int i = 1; i <= QtdeTaxPay; i++)
            {
                Console.WriteLine($"Tax player #{i} data:");
                Console.Write("Individual or Company (i/c) ? ");
                string TipoPessoa = Console.ReadLine();
                Console.Write("Name: ");
                string Name = Console.ReadLine();
                Console.Write("Anual income: ");
                double AnualValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (TipoPessoa == "i")
                {
                    Console.Write("Health expenditures: ");
                    double HealthValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Pessoas.Add(new PessoaFisica(Name, AnualValue, HealthValue));
                }
                else if (TipoPessoa == "c")
                {
                    Console.Write("Number of employees: ");
                    int NumberEmps = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Pessoas.Add(new PessoaJuridica(Name, AnualValue, NumberEmps));
                }
            }

            Console.WriteLine("");
            Console.WriteLine("TAXES PAID:");
            

            foreach (Pessoa p in Pessoas)
            {
                SomaTotal += p.Juros();
                Console.WriteLine($"{p.Nome}: $ {p.Juros().ToString("F02", CultureInfo.InvariantCulture)}");
            }

            Console.WriteLine("");
            Console.WriteLine($"TOTAL TAXES: $ {SomaTotal}");
        }
    }
}