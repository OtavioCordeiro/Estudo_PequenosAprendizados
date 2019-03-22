using System;

namespace Recursividade
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calc = new Calculadora();

            var result = calc.Multiplica(3, 4);

            Console.WriteLine(result);
        }
    }
}
