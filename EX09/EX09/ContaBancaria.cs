using System;

namespace EX09
{
    internal class ContaBancaria
    {
        private int _numConta;
        private string _nome;
        public double Saldo { get; private set; }

        public ContaBancaria(int numConta, string nome, double valorInicial) {
            _numConta = numConta;
            _nome = nome;
            Saldo = valorInicial;
        }

        public int NumConta
        {
            get { return _numConta; }
            set { 
                if (value != 0)
                {
                    _numConta = value;
                }
            }
        }

        public string Nome
        {
            get { return _nome; }
            set {
                if (_nome != null) { 
                    _nome = value;
                }
            }
        }

        public void Deposito(double ValorDeposito)
        {
            Saldo += ValorDeposito;
        }

        public void Saque(double ValorSaque)
        {
            Saldo = Saldo - ( ValorSaque + 5);
        }

    }
}
