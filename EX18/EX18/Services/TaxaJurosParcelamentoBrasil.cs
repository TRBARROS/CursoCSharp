namespace EX18.Services
{
    internal class TaxaJurosParcelamentoBrasil : IParcelamento
    {
        public string[] ParcelasArray { get; set; }
        public void Parcela(int Quantidade, double Valor)
        {
            for (int i = 1; i <= Quantidade; i++)
            {
                double VCalc = (Quantidade + (Quantidade * 0.1 * i)) + (Quantidade + (Quantidade * 0.2));
                DateTime DataAtual = DateTime.Now;
                DateTime AdicionaMes = DataAtual.AddMonths(i);
                ParcelasArray[i - 1] = AdicionaMes + " - " + Convert.ToString(VCalc);
            }
        }
    }
}
