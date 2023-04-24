namespace EX18.Services
{
    internal class TaxaJurosParcelamentoBrasil : IParcelamento
    {
        public double Parcela(double Valor, int Idx)
        { 
            return (Valor + (Valor * (0.01 * Idx))) + (Valor + (Valor * (0.01 * Idx))) * 0.02;
        }
    }
}
