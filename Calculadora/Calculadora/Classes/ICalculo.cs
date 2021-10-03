using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Classes
{
    internal interface ICalculo
    {
        decimal Somar(decimal valor1, decimal valor2);
        decimal Subtrair(decimal valor1, decimal valor2);
        decimal Multiplicar(decimal valor1, decimal valor2);
        decimal Dividir(decimal valor1, decimal valor2);
    }
}
