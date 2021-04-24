using System;
using System.Collections.Generic;
using System.Text;

namespace Testes
{
    class Calculator
    {
        public static int Sum(params int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
        //Ref int x -> altera a referência
        public static void Triple(int x, out int triple)
        {
            triple = x * 3;
        }

    }
}
