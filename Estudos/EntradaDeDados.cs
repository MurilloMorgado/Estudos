using Estudos.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudos
{
    internal class EntradaDeDados
    {
        private string area;

        public String PerguntarNome()
        {
            Console.WriteLine("Informe seu nome: ");
            String nome = Console.ReadLine();
            Console.WriteLine("Informe seu sobrenome: ");
            String sobreNome = Console.ReadLine();

            String resultado = "Seu nome é " + nome + sobreNome;
            return resultado;
        }


        public String calcularGeometria()
        {
            Geometria geometria = new Geometria();
            Console.WriteLine("Digite o numero da Geometria que deseja calcular:");
            Console.WriteLine("1 : Triangulo");
            Console.WriteLine("2 : Quadrado");
            int numero = int.Parse(Console.ReadLine());

            switch (numero)
            {
                case 1:
                    {
                        Console.WriteLine("Vamos calcular a area do triangulo");
                        Triangulo triangulo = new Triangulo();
                        Console.WriteLine("Digite o primeiro numero: ");
                        triangulo.A = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o segundo numero: ");
                        triangulo.B = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o terceiro numero: ");
                        triangulo.C = double.Parse(Console.ReadLine());
                        double area = geometria.triangulo(triangulo);
                        return area.ToString();
                    }
                case 2:
                    {
                        Console.WriteLine("Vamos calcular a area do triangulo");
                        Quadrado quadrado = new Quadrado();
                        Console.WriteLine("Digite o primeiro numero: ");
                        quadrado.A = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o segundo numero:");
                        quadrado.B = double.Parse(Console.ReadLine());
                        double area = geometria.quadrado(quadrado);
                        return area.ToString();
                    }
                default:
                    {
                        Console.WriteLine("Numero invalido");
                        break;
                    }

            }

            return area;
        }
    }


}
