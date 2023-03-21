using System;
using System.Globalization;

namespace EX10
{
    internal class AlugarQuarto
    {
        public string Name { get; private set; }
        public string Email { get; private set; }
        public int NumDoQuarto { get; private set; }

        public AlugarQuarto(string name, string email, int numdoquarto)
        {
            Name = name;
            Email = email;
            NumDoQuarto = numdoquarto;
        }

    }

}
