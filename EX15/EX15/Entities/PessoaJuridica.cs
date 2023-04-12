namespace EX15.Entities
{
    class PessoaJuridica : Pessoa
    {
        public int NumFuncionarios { get; set; }

        public PessoaJuridica() 
        {
        }

        public PessoaJuridica(string nome, double rendaanual, int numfuncionarios)
            : base(nome, rendaanual)
        {
            NumFuncionarios = numfuncionarios;
        }

        public override double Juros()
        {
            double VarRetorno;

            if (NumFuncionarios > 10)
            {
                VarRetorno = RendaAnual * 0.14;
            }
            else
            {
                VarRetorno = RendaAnual * 0.16;
            }

            return VarRetorno;
        }
    }
}
