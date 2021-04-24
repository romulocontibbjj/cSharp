using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Testes
{
    class Produto2
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto2()
        {
            Quantidade = 10;
        }

        public Produto2(string nome, double preco, int qtd)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = qtd;
        }

        public Produto2(string nome, double preco) : this()
        {
            Nome = nome;
            Preco = preco;
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
            xMsg = "Dados Atualizados: " + Nome +
                                ", $ " + Preco.ToString("F2", CultureInfo.InvariantCulture) +
                                ", " + Quantidade.ToString() + " unidades " +
                                ", Total: $" + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);

            return xMsg.ToString();
        }
    }
}
