using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Testes
{
    class Produto4
    {
        private string _nome;
        private double _preco;
        private int _quantidade;

        
        public Produto4()
        {
            _quantidade = 10;
        }

        public Produto4(string nome, double preco, int qtd)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = qtd;
        }

        public Produto4(string nome, double preco) : this()
        {
            _nome = nome;
            _preco = preco;
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

        public double Preco
        {
            get { return _preco; }
        }
        public int Quantidade
        {
            get { return _quantidade; }
        }

        public double ValorTotalEmEstoque()
        {
            double resultado = 0;
            resultado = (_preco * _quantidade);
            return resultado;
        }

        public void AdicionarProdutos(int Quant)
        {
            _quantidade += Quant;
        }

        public void RemoverProdutos(int Quant)
        {
            _quantidade -= Quant;
        }

        public override string ToString()
        {
            string xMsg;
            xMsg = "Dados Atualizados: " + _nome +
                                ", $ " + _preco.ToString("F2", CultureInfo.InvariantCulture) +
                                ", " + _quantidade.ToString() + " unidades " +
                                ", Total: $" + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);

            return xMsg.ToString();
        }
    }
}
