using System;
using System.Globalization;

namespace Estudos.aulas.aula46
{
    internal class Aula46
    {
        public void CalcularCircunferencia()
        {
            Console.Write("Informe o valor do raio:");
            double raio= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            string circ = Calculadora.Circunferencia(raio).ToString("F2", CultureInfo.InvariantCulture);
            string vol = Calculadora.Volume(raio).ToString("F2", CultureInfo.InvariantCulture);

            Console.WriteLine("Circulo: " + circ);
            Console.WriteLine("Volume: " + vol);
            Console.WriteLine("Valor de PI: " + Calculadora.pi.ToString("F2", CultureInfo.InvariantCulture));
        }
        


    }
}
