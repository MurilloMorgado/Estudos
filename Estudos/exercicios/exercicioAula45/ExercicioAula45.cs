using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Estudos.exercicios.exercicioAula45
{
    internal class ExercicioAula45
    {
        public void areasDoTriangulo()
        {
            Triangulo triangulo = new Triangulo();
            Console.Clear();
            Console.WriteLine("Informe a largura do triangulo");
            triangulo.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Informe a altura do triangulo");
            triangulo.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Area = " + triangulo.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Perimetro = " + triangulo.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal = " + triangulo.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
            
        }
    }
}
