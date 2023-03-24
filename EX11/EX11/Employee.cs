using System;

namespace EX11
{
    internal class Employee
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public double Salary { get; private set; }

        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void IncreaseSalary(double percentage)
        {
            double PercentDecimal = percentage / 100;
            Salary = Salary + (Salary * PercentDecimal);
        }

    }
}
