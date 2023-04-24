using EX18.Services;
using System.Globalization;

namespace EX18.Entities
{
    public class Installment
    {
        public double Valor { get; private set; }
        public DateTime DataParcela { get; private set; }
        public int Index { get; private set; }
        private IParcelamento _installments;

        public Installment() 
        {
        }

        public Installment(double valor, DateTime dataParcela, int index, IParcelamento installments)
        {
            Valor = valor;
            DataParcela = dataParcela;
            Index = index;
            _installments = installments;
        }

        public void RetornaParcelas()
        {
            double ValorParcela = _installments.Parcela(Valor, Index);
            Console.WriteLine(DataParcela.ToString("dd/MM/yyyy") + " - " + ValorParcela.ToString("F02", CultureInfo.InvariantCulture));
        }
    }
}