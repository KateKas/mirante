namespace Questao1
{
    class ContaBancaria {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        protected const double TAXA_SAQUE = 3.5;

        public ContaBancaria(int numero, string titular, double depositoInicial = 0)
        {
            this.Numero = numero;
            this.Titular = titular;
            this.Saldo = depositoInicial;
        }

        public void Deposito(double quantia)
        {
            this.Saldo += quantia;
        }

        public void Saque(double quantia)
        {           
            this.Saldo -= (quantia + TAXA_SAQUE);            
        }

        public override string ToString() {
            return $"Conta: {this.Numero}, Titular: {this.Titular}, Saldo $ {this.Saldo:f2}" ;
        }

    }
}
