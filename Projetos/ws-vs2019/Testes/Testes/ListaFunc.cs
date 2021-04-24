using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Testes
{
    class ListaFunc
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }

        public ListaFunc(int id, string nome, double salario)
        {
            ID = id;
            Nome = nome;
            Salario = salario;
        }

        public void Reajuste(double valor)
        {
            Salario = (Salario * (1 + (valor/100)));
        }

        public override string ToString()
        {
            string msg;
            msg = ID + ", " + Nome + ", R$ " + Salario.ToString("F2", CultureInfo.InvariantCulture);
            return msg.ToString();
        }
    }
}
