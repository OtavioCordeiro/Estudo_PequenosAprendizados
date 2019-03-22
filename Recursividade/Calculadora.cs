using System;
using System.Collections.Generic;
using System.Text;

namespace Recursividade
{
    public class Calculadora
    {
        public int Multiplica(int num1, int num2)
        {
            if (num1 == 0 || num2 == 0) return 0;

            if (num2 == 1) return num1;

            return num1 + (Multiplica(num1, num2 - 1));
        }
    }
}
