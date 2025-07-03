using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Estudos.exercicios.exercicioAula48
{
    internal class ExercicioAula48
    {
        public void CalcularValorAPargar()
        {
            Console.WriteLine("Calcular o valor a se pago");
            Console.Write("Informe a cotação do dólar: ");
            double cotacaoDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você deseja comprar ? ");
            double quantidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double valorComIof = ConversorDeMoeda.CalcularIof(quantidade, cotacaoDolar);

            Console.WriteLine("Valor a ser pago em reais = " + valorComIof.ToString("F2", CultureInfo.InvariantCulture));
        }

    }
}
