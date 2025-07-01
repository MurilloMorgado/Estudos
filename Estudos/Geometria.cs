using Estudos.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudos
{
    internal class Geometria
    {
        //Calcular Triangulo
        public double triangulo(Triangulo triangulo)
        {
            double a = triangulo.A;
            double b = triangulo.B;
            double c = triangulo.C;
            double p = (a + b + c) / 2;
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return area;
        }

        public double quadrado(Quadrado quadrado)
        {
            double a = quadrado.A;
            double b = quadrado.B;
            double area = a * b;
            return area;
        }

    }
}
