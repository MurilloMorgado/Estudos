using Estudos.aulas.aula42;
using Estudos.exercicios.exercicioAula45;
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
        public void EscolherAcao()
        {
            int id = 0;
            Console.WriteLine("Digite o numero que deseja executar");
            Console.WriteLine("1 - Controle de Estoque / Total em Estoque");
            Console.WriteLine("2 - Areas do triangulo");
            id = int.Parse(Console.ReadLine());

            switch (id)
            {
                case 1:
                    {
                        ControleDeEstoque controleDeEstoque = new ControleDeEstoque();
                        controleDeEstoque.TotalEmEstoque();
                        break;
                    }
                case 2:
                    {
                        ExercicioAula45 exercicioAula45 = new ExercicioAula45();
                        exercicioAula45.areasDoTriangulo();
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }

        //Essas duas funçoes vao ser removidas e transferidas para seus respectivos lugares posteriormente
        public string PerguntarNome()
        {
            Console.WriteLine("Informe seu nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Informe seu sobrenome: ");
            string sobreNome = Console.ReadLine();

            string resultado = "Seu nome é " + nome + sobreNome;
            return resultado;
        }


        public void calcularGeometria()
        {
            Console.WriteLine("Digite o numero da Geometria que deseja calcular:");
            Console.WriteLine("1 : Triangulo");
            Console.WriteLine("2 : Quadrado");
            int numero = int.Parse(Console.ReadLine());

            switch (numero)
            {
                case 1:
                    {
                        Console.WriteLine("Vamos calcular a area do triangulo");
                        models.Triangulo triangulo = new models.Triangulo();
                        Console.WriteLine("Digite o primeiro numero: ");
                        triangulo.A = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o segundo numero: ");
                        triangulo.B = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o terceiro numero: ");
                        triangulo.C = double.Parse(Console.ReadLine());
                        double Area = triangulo.Area();
                        Console.WriteLine("A area do triangulo é: " + Area);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Vamos calcular a area do quadrado");
                        Quadrado quadrado = new Quadrado();
                        Console.WriteLine("Digite o primeiro numero: ");
                        quadrado.A = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o segundo numero:");
                        quadrado.B = double.Parse(Console.ReadLine());
                        double Area = quadrado.Area();
                        Console.WriteLine("A area do quadrado é: " + Area);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Numero invalido");
                        break;
                    }

            }

        }
    }


}
