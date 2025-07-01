using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudos.Exercicio_1
{
    internal class CompararPessoa
    {
        public void compararPessoaMaisVelha()
        {
            Pessoa X = new Pessoa();
            Pessoa Y = new Pessoa();

            Console.WriteLine("Informe o nome da primeira pessoa");
            X.Nome = Console.ReadLine();

            Console.WriteLine("Informe a idade da primeira pessoa");
            X.Idade = int.Parse(Console.ReadLine());

            //Recebendo a segunda pessoa
            Console.WriteLine("Informe o nome da segunda pessoa");
            Y.Nome = Console.ReadLine();

            Console.WriteLine("Informe a idade da segunda pessoa");
            Y.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Analisando quem é a pessoa mais velha...");

            if (X.Idade > Y.Idade)
            {
                Console.WriteLine(X.Nome + " é mais velho(a);");
                return;
            }

            Console.WriteLine(Y.Nome + " é mais velho(a);");
        }
    }
}
