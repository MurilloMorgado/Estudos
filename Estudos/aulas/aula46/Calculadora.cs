using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudos.aulas.aula46
{
    internal class Calculadora
    {
        public static double pi = 3.14;

        public static double Circunferencia(double raio)
        {
            return 2.0 * pi * raio;
        }

        public static double Volume(double raio)
        {
            return ((4.0 / 3.0) * pi * Math.Pow(raio, 3.0));
        }
    }
}
