namespace EX15.Entities
{
    class PessoaFisica : Pessoa
    {
        public double GastosComSaude { get; set; }

        public PessoaFisica() 
        {
        }

        public PessoaFisica(string nome, double rendaanual, double gastoscomsaude)
            :base(nome, rendaanual)
        {
            GastosComSaude = gastoscomsaude;
        }
        public override double Juros()
        {
            double VarRetorno;

            if (RendaAnual < 20000)
            {
                VarRetorno = (RendaAnual * 0.15) - (GastosComSaude * 0.5);
            } 
            else
            {
                VarRetorno = (RendaAnual * 0.25) - (GastosComSaude * 0.5);
            }

            return VarRetorno;
        }
    }
}
