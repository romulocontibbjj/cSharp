using System;
using System.Collections.Generic;
using System.Text;

namespace Testes
{
    class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
            double resultado = 0;
            resultado = Largura * Altura;
            return resultado;
        }

        public double Perimetro()
        {
            double resultado = 0;
            resultado = 2 * (Largura + Altura);
            return resultado;
        }

        public double Diagonal()
        {
            double resultado = 0;
            resultado = Math.Sqrt(Largura * Largura + Altura * Altura);
            return resultado;
        }
    }
}
