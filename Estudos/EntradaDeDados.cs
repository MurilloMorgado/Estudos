﻿using Estudos.aulas.aula42;
using Estudos.aulas.aula46;
using Estudos.aulas.aula69;
using Estudos.aulas.aula70;
using Estudos.exercicios.exercicioAula45;
using Estudos.exercicios.exercicioAula48;
using Estudos.exercicios.exercicioAula60;
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
            ExercicioAula48 exercicioAula48 = new ExercicioAula48();
            ExercicioAula60 exercicioAula60 = new ExercicioAula60();
            Aula69 aula69 = new Aula69();
            Aula70 aula70 = new Aula70();

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
                case 6:
                    {
                        exercicioAula48.CalcularValorAPargar();
                        break;
                    }
                case 7:
                    {
                        exercicioAula60.Banco();
                        break;
                    }
                case 8:
                    {
                        aula69.CalcularMediaDeAltura();
                        break;
                    }
                case 9:
                    {
                        aula70.CalcularMediaDosProdutos();
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
            Console.WriteLine("6 - Calcular pagamento");
            Console.WriteLine("7 - Conta Bancaria");
            Console.WriteLine("8 - Calcular Media de alturas");
            Console.WriteLine("9 - Calcular Media dos produtos");
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
