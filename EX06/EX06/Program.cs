using System;
using System.Globalization;

namespace EX06
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario F1 = new Funcionario();

            Console.WriteLine("Digite o nome do funcionário:");
            F1.Nome = Console.ReadLine();
            Console.WriteLine("Digite o salário bruto do funcionário:");
            F1.SalarioBruto = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o valor dos impostos:");
            F1.Imposto = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Funcionário: {F1.Nome}, $ {F1.SalarioLiquido().ToString("F02", CultureInfo.InvariantCulture)}");

            Console.WriteLine("Digite a porcentagem para aumentar o salário:");
            double Porcentagem = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            F1.AumentarSalario(Porcentagem);

            Console.WriteLine($"Dados atualizados: {F1.Nome}, $ {F1.SalarioBruto.ToString("F02", CultureInfo.InvariantCulture)}");
        }
    }
}