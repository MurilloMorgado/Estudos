using System;
using System.Globalization;

namespace Estudos.aulas.aula46
{
    internal class Aula46
    {
        static double pi = 3.14;
        public void CalcularCircunferencia()
        {
            Console.Write("Informe o valor do raio:");
            double raio= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            string circ = circunferencia(raio).ToString("F2", CultureInfo.InvariantCulture);
            string vol = Volume(raio).ToString("F2", CultureInfo.InvariantCulture);

            Console.WriteLine("Circulo: " + circ);
            Console.WriteLine("Volume: " + vol);
            Console.WriteLine("Valor de PI: " + pi);
        }
        
        static double circunferencia(double raio)
        {
            return 2.0 * pi * raio;
        }

        static double Volume(double raio)
        {
            return ((4.0 / 3.0) * pi * Math.Pow(raio, 3.0));
        }

    }
}
