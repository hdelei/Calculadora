using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Classes
{
    public abstract class Calculo
    {
        public decimal Somar(decimal valor1, decimal valor2) 
        {
            return valor1 + valor2;
        }
        public decimal Subtrair(decimal valor1, decimal valor2)
        {
            return valor1 - valor2;
        }

        public decimal Multiplicar(decimal valor1, decimal valor2) {
            return valor1 * valor2;
        }
        public decimal Dividir(decimal valor1, decimal valor2)
        {
            return valor1 / valor2;
        }
    }
}
