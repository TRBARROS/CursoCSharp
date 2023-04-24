using EX18.Entities;
using System.Globalization;

namespace EX18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int NumberContract = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime DateContact = DateTime.Parse(Console.ReadLine());
            Console.Write("Contract Value: ");
            double ContractValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter number os installments: ");
            int InstallmentsCt = int.Parse(Console.ReadLine());

            Contract Contrato = new Contract(NumberContract, DateContact, ContractValue, InstallmentsCt);

            foreach(Installment Parcelas in Contrato.Parcelas)
            {
                Parcelas.RetornaParcelas();
            }
        }
    }
}
