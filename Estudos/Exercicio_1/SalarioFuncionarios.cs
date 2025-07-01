using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudos.Exercicio_1
{
    internal class SalarioFuncionarios
    {

        public void SalarioMedio()
        {
            Pessoa A = new Pessoa();
            Pessoa B = new Pessoa();

            Console.WriteLine("Informe o nome da primeira pessoa");
            A.Nome = Console.ReadLine();
            Console.WriteLine("Qual o salario de " + A.Nome + " ?");
            A.Salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o nome da segunda pessoa");
            B.Nome = Console.ReadLine();
            Console.WriteLine("Qual o salario de " + B.Nome + " ?");
            B.Salario = double.Parse(Console.ReadLine());

            double SalarioMedio = (A.Salario + B.Salario) / 2;
            Console.WriteLine("O salario medio de " + A.Nome + " e " + B.Nome + " é: " + SalarioMedio);
        }
    }
}
