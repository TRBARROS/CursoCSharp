using System;
using System.Globalization;

namespace EX10
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumQuartos;
            AlugarQuarto[] Vect = new AlugarQuarto[10];

            Console.WriteLine("How many rooms will be rented ?");
            NumQuartos = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < NumQuartos; i++)
            {
                Console.WriteLine($"Rent #{i + 1}");
                Console.WriteLine("Nome da pessoa a alugar:");
                string Name = Console.ReadLine();
                Console.WriteLine("Email da Pessoa que esta alugando:");
                string Email = Console.ReadLine();
                Console.WriteLine("Numero do quarto a ser alugado;");
                Int32 NumDoQuarto = Convert.ToInt32(Console.ReadLine());

                Vect[NumDoQuarto] = new AlugarQuarto(Name, Email, NumDoQuarto);
            }

            Console.WriteLine("Busy rooms:");
            for (int i = 0; i < 10; i++)
            {
                if (Vect[i] != null)
                {
                    Console.WriteLine($"{i}: {Vect[i].Name}, {Vect[i].Email}");
                }
            }
            

        }
    }
}