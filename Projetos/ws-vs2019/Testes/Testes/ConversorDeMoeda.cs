using System;
using System.Collections.Generic;
using System.Text;

namespace Testes
{
    class ConversorDeMoeda
    {
        public static double imposto = 0.06; //6%
        public static double ValorEmReais(double valorDolar, double Qtd)
        {
            return ((Qtd * valorDolar) * (1+imposto));
        }


    }
}
