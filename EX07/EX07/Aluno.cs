using System;
using System.Security.Cryptography.X509Certificates;

namespace EX07
{
    class Aluno
    {
        public string Name;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public double SomaNotas()
        {
            return Nota1 + Nota2 + Nota3;
        }

        public double Diferenca()
        {
            return 60.00 - SomaNotas();
        }
    }
}
