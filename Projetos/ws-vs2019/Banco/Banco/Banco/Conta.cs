using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Banco
{
    class Conta
    {
        public string Nome { get; set; }
        public int ContaCorrente { get; private set; }
        public double Saldo { get; private set; }

        public Conta()
        {

        }
        public Conta(string nome, int contaCorrent)
        {
            Nome = nome;
            ContaCorrente = contaCorrent;
        }

        public Conta(string nome, int contaCorrent, double saldo): this( nome, contaCorrent)
        {
            Saldo = saldo;
        }
        
        public void Saque(double valorSaque)
        {
            double taxaSaque = 5.00;
            Saldo -= valorSaque;
            Saldo -= taxaSaque;
        }

        public void Deposito(double deposito)
        {
            Saldo += deposito;
        }

        public override string ToString()
        {
            string msg;
            msg = "Cliente: " + Nome.ToString() + " - CC: " + ContaCorrente.ToString() +
                    " - Saldo: R$ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
            return msg.ToString();
        }

    }
}
