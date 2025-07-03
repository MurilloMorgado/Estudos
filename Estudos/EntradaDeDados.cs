using Estudos.aulas.aula42;
using Estudos.aulas.aula46;
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
            ControleDeEstoque controleDeEstoque = new ControleDeEstoque();
            ExercicioAula45 exercicioAula45 = new ExercicioAula45();
            Aula46 aula46 = new Aula46();

            ExibirMenu();

            int id = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (id)
            {
                case 0:
                    {
                        break;
                    }
                case 1:
                    {
                        controleDeEstoque.TotalEmEstoque();
                        break;
                    }
                case 2:
                    {
                        exercicioAula45.AreasDoTriangulo();
                        break;
                    }
                case 3:
                    {
                        exercicioAula45.CalcularSalarioFinal();
                        break;
                    }
                case 4:
                    {
                        exercicioAula45.CalularNotaFinalDeAluno();
                        break;
                    }
                case 5:
                    {
                        aula46.CalcularCircunferencia();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Opção invalida");
                        break;
                    }
            }
        }

        public void ExibirMenu()
        {
            Console.WriteLine("Menu de opções");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("1 - Controle de Estoque");
            Console.WriteLine("2 - Áreas do Triângulo");
            Console.WriteLine("3 - Calcular Salário");
            Console.WriteLine("4 - Nota final de Aluno");
            Console.WriteLine("5 - Calcular circunferêrencia");
            Console.WriteLine();
            Console.Write("Digite o número que deseja executar:");
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
