using System;

namespace Banco.Contas
{
    public class Conta
    {
        public int numero { get; set; }
        public double saldo { get; private set; }
        internal Cliente Titutar { get; set; }
        public Conta(int Numero, string Titular, double Saldo) {

            this.numero = Numero;
            this.saldo = Saldo;
            this.Titutar = new Cliente(Titular);
        }
        
                 
    
    
    
        public Conta()
        {
        }

        public virtual void Deposita(double valorOperacao)
        {
            saldo += valorOperacao;
        }

        public virtual void Saca(double valorOperacao)
        {
            saldo -= valorOperacao;
        }
    }
}