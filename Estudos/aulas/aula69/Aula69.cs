using System;
using System.Globalization;

namespace Estudos.aulas.aula69
{
    internal class Aula69
    {

        public void CalcularMediaDeAltura()
        {
            Console.Write("Insira a quantidades de altura: ");
            int quantidade = int.Parse(Console.ReadLine());

            double[] vect = new double[quantidade];
            Console.WriteLine("Insira as alturas: ");
            for (int i = 0; i < quantidade; i++)
            {
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double soma = 0.0;
            for(int i = 0; i< quantidade; i++)
            {
                soma += vect[i];
            }

            double resultado = soma / quantidade;

            Console.WriteLine("A media das alturas é " + resultado.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
