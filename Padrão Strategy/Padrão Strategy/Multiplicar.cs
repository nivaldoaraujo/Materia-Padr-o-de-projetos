using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padrão_Strategy
{
    class Multiplicar:Calculadora
    {
        public override double Operacao(double v1, double v2)
        {
            return v1 * v2;
        }
    }
}
