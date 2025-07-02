using System;
using System.Globalization;

namespace Estudos.aulas.aula42
{
    internal class ControleDeEstoque
    {
        public void TotalEmEstoque()
        {
            Produto produto = new Produto();

            Console.WriteLine("Informe os dados do produto");

            Console.WriteLine("Digite o nome do produto:");
            produto.Nome = Console.ReadLine();

            Console.WriteLine("Digite o preço do produto " +  produto.Nome + ":");
            produto.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite a quantidade em estoque:");
            produto.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do produto: " + produto);

        }

    }
}
