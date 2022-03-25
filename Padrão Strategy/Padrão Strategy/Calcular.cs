using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padrão_Strategy
{
    class Calcular        
    {
        public Calculadora calcular { get; set; }
        public void CalcularOperacao(double v1, double v2)
        {
            Console.WriteLine(calcular.Operacao(v1, v2));
        }
    }
}
