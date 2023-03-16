using System;

namespace EX06
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            double PorcentagemDec = porcentagem / 100;
            double PorcentagemSal = SalarioBruto * PorcentagemDec;
            double SalarioAumentado = SalarioLiquido() + PorcentagemSal;
            SalarioBruto = SalarioAumentado;
        }
    }
}
