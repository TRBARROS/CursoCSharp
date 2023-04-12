using EX16.Entities;
using EX16.Entities.Exceptions;
using System.Globalization;

namespace EX16
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data:");
                Console.Write("Number: ");
                int NumberAcc = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string NameAcc = Console.ReadLine();
                Console.Write("Initial balance: ");
                double InitBalanceAcc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw Limit: ");
                double WithdrawLimitAcc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account AccIns = new Account(NumberAcc, NameAcc, InitBalanceAcc, WithdrawLimitAcc);

                Console.WriteLine("");
                Console.Write("Enter amount for withdraw: ");
                double AmountWithdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                AccIns.Withdraw(AmountWithdraw);

                Console.WriteLine($"New balance: {AccIns.Balance.ToString("F02", CultureInfo.InvariantCulture)}");
            }
            catch (DomainException e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Anything have error contact the system admin");
            }
        }
    }
}