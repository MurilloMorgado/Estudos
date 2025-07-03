using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudos.exercicios.exercicioAula48
{
    internal class ConversorDeMoeda
    {
        public static double Iof = 6;
        public static double CalcularIof(double valor, double cotacaoAtual)
        {
            double total = valor * cotacaoAtual;
            return total + (total * (Iof / 100));
        }

    }
}
