using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Estudos.aulas.aula42;

namespace Estudos.exercicios.exercicioAula45
{
    internal class ExercicioAula45
    {
        public void AreasDoTriangulo()
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
        public void CalcularSalarioFinal()
        {
            Funcionario funcionario = new Funcionario();
            Console.WriteLine("Informações do funcionario:");
            Console.WriteLine("Digite o nome do funcionario");
            funcionario.Nome = Console.ReadLine();

            Console.WriteLine("Informe o salário bruto:");
            funcionario.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Informe o imposto:");
            funcionario.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Funcionário: " + funcionario.ToString());

            Console.WriteLine("Digite a porcentagem para aumentar o salário:");
            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            funcionario.AumentarSalario(porcentagem);

            Console.WriteLine("Dados Atualizados: " + funcionario.ToString());
        }
        public void CalularNotaFinalDeAluno()
        {
            Console.Clear();
            Aluno aluno = new Aluno();
            Console.WriteLine("Informe o nome do Aluno");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Informe a primeira nota");
            aluno.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Informe a segunda nota");
            aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Informe a terceira nota");
            aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double notaFinal = aluno.NotaFinal();
            Console.WriteLine("Nota Final = " + notaFinal);
            bool aprovado = aluno.Aprovado(notaFinal);

            if (aprovado == true)
            {
                Console.WriteLine("Aluno aprovado");
            }
            else
            {
                double notaRestante = aluno.NotaRestante();
                Console.WriteLine("Aluno reprovado, faltaram " + notaRestante + " pontos");
            };
        }
    }


}
