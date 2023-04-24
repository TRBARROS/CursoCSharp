using EX18.Services;

namespace EX18.Entities
{
    internal class Contract
    {
        public int NumContrato { get; private set; }
        public DateTime DataContrato { get; private set; }
        public double ValorContrato { get; private set; }
        public int QuantidadeParcelas { get; private set; }

        public List<Installment> Parcelas { get; private set; }
        
        public Contract()
        {
        }

        public Contract (int numContrato, DateTime dataContrato, double valorContrato, int quantidadeParcelas)
        {
            NumContrato = numContrato;
            DataContrato = dataContrato;
            ValorContrato = valorContrato;
            QuantidadeParcelas = quantidadeParcelas;

            Parcelas = new List<Installment>();

            double ValorCadaParcela;
            ValorCadaParcela = valorContrato / quantidadeParcelas;

            for (int i = 1; i <= quantidadeParcelas; i++)
            {
                DateTime DataParcela = DataContrato.AddMonths(i);
                Parcelas.Add(new Installment(ValorCadaParcela, DataParcela, i, new TaxaJurosParcelamentoBrasil()));
            }
        }
        
    }
}

/*
 


 */