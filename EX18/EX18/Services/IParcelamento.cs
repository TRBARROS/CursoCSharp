namespace EX18.Services
{
    public interface IParcelamento
    {
        public string[] ParcelasArray { get; set; }
        public void Parcela(int Quantidade, double Valor);
    }
}
