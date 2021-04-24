using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
    
namespace Testes
{
    class Produto5
    {
        private string _nome;
        public double Preco { get; private set; }
        public double Quantidade { get; private set; }

        public Produto5()
        {
            Quantidade = 10;
        }

        public Produto5(string nome, double preco, int qtd)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = qtd;
        }

        public Produto5(string nome, double preco) : this()
        {
            _nome = nome;
            Preco = preco;
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        public double ValorTotalEmEstoque()
        {
            double resultado = 0;
            resultado = (Preco * Quantidade);
            return resultado;
        }

        public void AdicionarProdutos(int Quant)
        {
            Quantidade += Quant;
        }

        public void RemoverProdutos(int Quant)
        {
            Quantidade -= Quant;
        }

        public override string ToString()
        {
            string xMsg;
            xMsg = "Dados Atualizados: " + _nome +
                                ", $ " + Preco.ToString("F2", CultureInfo.InvariantCulture) +
                                ", " + Quantidade.ToString() + " unidades " +
                                ", Total: $" + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);

            return xMsg.ToString();
        }
    }
}
