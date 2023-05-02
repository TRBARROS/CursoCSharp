using System.Globalization;
using EX19.Entities;
using System.Linq;

namespace EX19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path: ");
            string Path = Console.ReadLine();
            Console.Write("Enter salary: ");
            double SalaryEmp = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Email of people whose salary is more than {SalaryEmp}");

            List<Funcionarios> EmployeeList = new List<Funcionarios>();

            using (StreamReader Sr = new StreamReader(Path))
            {
                while (!Sr.EndOfStream)
                {
                    string Line = Sr.ReadLine();
                    string[] VecLine = Line.Split(',');
                    EmployeeList.Add(new Funcionarios(VecLine[0], VecLine[1], Double.Parse(VecLine[2], CultureInfo.InvariantCulture)));
                }
            }

            var Emails = EmployeeList.Where(p => p.Salary > SalaryEmp).Select(p => p.Email).OrderBy(p => p);

            foreach (string Email in Emails)
            {
                Console.WriteLine(Email);
            }

            var SalaryNmStWithM = EmployeeList.Where(p => p.Name.StartsWith("M")).Select(p => p.Salary);

            double SalarySum = 0.0;

            foreach (Double Salary in SalaryNmStWithM)
            {
                SalarySum += Salary;
            }

            Console.WriteLine($"Sum of salary of people whose name starts with 'M': {SalarySum.ToString("F02", CultureInfo.InvariantCulture)}");
        }
    }
}