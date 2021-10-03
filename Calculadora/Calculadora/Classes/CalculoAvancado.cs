using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Classes
{
    class CalculoAvancado: Calculo
    {
        public double RaizQuadrada(double valor)
        {
            return Math.Sqrt(valor);
        }
    }
}
