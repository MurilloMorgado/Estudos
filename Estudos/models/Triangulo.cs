using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudos.models
{
    internal class Triangulo
    {
        public double A;
        public double B;
        public double C;

        public double Area()
        {
            double P = (A + B + C) / 2;
           return Math.Sqrt(P * (P - A) * (P - B) * (P - C));
        }

    }
}
