using System;
using System.Globalization;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            string cliente;
            int contaCorrent;
            double saldo;
            double valorAux = 0;
            
            Console.WriteLine("Banco Teste - Abertura de Conta");
            Console.Write("Cliente: ");
            cliente = Console.ReadLine();
            Console.Write("Conta Corrente: ");
            contaCorrent = int.Parse(Console.ReadLine());
            Console.Write("Saldo Inicial: ");
            saldo = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Conta conta;

            if (saldo == 0)
            {
                conta = new Conta(cliente, contaCorrent);
            }
            else
            {
                conta = new Conta(cliente, contaCorrent, saldo);
            }

            Console.WriteLine("Informações: " + conta.ToString());

            Console.Write("Reaize um Depósito: R$ ");
            valorAux = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(valorAux);
            Console.WriteLine("Informações: " + conta.ToString());

            Console.Write("Reaize um Saque: R$ ");
            valorAux = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(valorAux);
            Console.Write("Informações: " + conta.ToString());


        }
    }
}
