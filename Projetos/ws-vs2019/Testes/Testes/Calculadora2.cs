using System;
using System.Collections.Generic;
using System.Text;

namespace Testes
{
    class Calculadora2
    {
        public static double Pi2 = 3.14;

        public static double Circunferencia2(double xraio)
        {
            return 2.0 * Pi2 * xraio;
        }
        
        public static double Volume2(double r)
        {
            //Math.Pow(r, 3) -> raio ao cubo
            return 4.0 / 3.0 * Pi2 * Math.Pow(r, 3);
        }
    }
}
