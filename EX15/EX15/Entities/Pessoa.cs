
namespace EX15.Entities
{
    abstract class Pessoa
    {
        public string Nome { get; set; }
        public double RendaAnual { get; set; }

        public Pessoa() 
        { 
        }

        public Pessoa(string nome, double rendaanual) 
        {
            Nome = nome;
            RendaAnual = rendaanual;
        }

        public abstract double Juros();
    }
}
