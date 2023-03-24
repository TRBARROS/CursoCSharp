using System;
using System.Globalization;
using System.Collections.Generic;

namespace EX11
{
    class Program
    {
        static void Main(string[] args)
        {
            int Qtde;
            int IdEmployee;

            List<Employee> Employs = new List<Employee>();

            Console.WriteLine("How many employees will be resgistered?");
            Qtde = Convert.ToInt32(Console.ReadLine(), CultureInfo.InvariantCulture);

            for (int i = 1; i <= Qtde; i++)
            {
                Console.WriteLine($"Emplyoee #{i}");
                Console.Write("Id: ");
                int Id = Convert.ToInt32(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Name: ");
                string Name = Console.ReadLine();
                Console.Write("Salary: ");
                double Salary = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

                Employs.Add(new Employee(Id, Name, Salary));
            }

            Console.Write("Enter the employee id that will have salary increase:");
            IdEmployee = Convert.ToInt32(Console.ReadLine(), CultureInfo.InvariantCulture);

            bool EmployeeIdFind = Employs.Exists(x => x.Id == IdEmployee);

            if (EmployeeIdFind)
            {
                Console.WriteLine("Enter the percentage");
                double Percent = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
                Employee ObjId = Employs.Find(x => x.Id == IdEmployee);
                ObjId.IncreaseSalary(Percent);

                Console.WriteLine("Updated list of employees");
                foreach (Employee emp in Employs)
                {
                    Console.WriteLine($"{emp.Id}, {emp.Name}, {emp.Salary}");
                }
            }
            else
            {
                Console.WriteLine("This id does not exist!");
                Console.WriteLine("");
                Console.WriteLine("Updated list of employees");
                foreach (Employee emp in Employs)
                {
                    Console.WriteLine($"{emp.Id}, {emp.Name}, {emp.Salary}");
                }
            }
        }
    }
}