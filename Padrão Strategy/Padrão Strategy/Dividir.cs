using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padrão_Strategy
{
    class Dividir:Calculadora
    {
        public override double Operacao(double v1, double v2)
        {
            if (v2 == 0)
                throw new InvalidOperationException();
            return v1 / v2;
        }
    }
}
