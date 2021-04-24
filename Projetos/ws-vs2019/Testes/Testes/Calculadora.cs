using System;
using System.Collections.Generic;
using System.Text;

namespace Testes
{
    class Calculadora
    {
        public double Pi = 3.14;

        public double Circunferencia(double xraio)
        {
            return 2.0 * Pi * xraio;
        }

        public double Volume(double r)
        {
            //Math.Pow(r, 3) -> raio ao cubo
            return 4.0 / 3.0 * Pi * Math.Pow(r, 3);
        }
    }
}
