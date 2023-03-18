using System;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace EX09
{
    class Program
    {
        static void Main(string[] args)
        {
            int Conta;
            string Nome;
            double ValorInicial;
            string DecideCTemVI;

            Console.WriteLine("Entre com o número da conta:");
            Conta = Convert.ToInt32(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com o titular da conta");
            Nome = Console.ReadLine();
            Console.WriteLine("Haverá depósito inicial (s/n)?");
            DecideCTemVI = Console.ReadLine().ToLower();

            if (DecideCTemVI == Convert.ToString('s'))
            {
                Console.WriteLine("Digite o valor inicial");
                ValorInicial = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            else
            {
                ValorInicial = 00.00;
            }
            ContaBancaria c1 = new ContaBancaria(Conta, Nome, ValorInicial);
            Console.WriteLine("Dados da conta:");
            Console.WriteLine($"Conta {c1.NumConta}, Titular: {c1.Nome}, Saldo: $ {c1.Saldo.ToString("F02", CultureInfo.InvariantCulture)}");

            Console.WriteLine("Entre com um valor para depósito:");
            c1.Deposito(Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine("Dados Atualizados:");
            Console.WriteLine($"Conta {c1.NumConta}, Titular: {c1.Nome}, Saldo: $ {c1.Saldo.ToString("F02", CultureInfo.InvariantCulture)}");

            Console.WriteLine("Entre com um valor para saque");
            c1.Saque(Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine("Dados atualizados:");
            Console.WriteLine($"Conta {c1.NumConta}, Titular: {c1.Nome}, Saldo: $ {c1.Saldo.ToString("F02", CultureInfo.InvariantCulture)}");


        }
    }
}