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

            Console.WriteLine("Digite o preço do produto " + produto.Nome + ":");
            produto.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite a quantidade em estoque:");
            produto.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do produto: " + produto);

            Console.WriteLine("Deseja adicionar um produto ao estoque ? ");
            Console.WriteLine("1 - Sim ");
            Console.WriteLine("2 - Não ");
            int adicionar = int.Parse(Console.ReadLine());
            if (adicionar == 1)
            {
                Console.WriteLine("Informe a quantidade que deseja adcionar: ");
                int quantidadeAdcionada = int.Parse(Console.ReadLine());
                produto.AdicionarProdutoEmEstoque(quantidadeAdcionada);
                Console.WriteLine("Dados do produto: " + produto);
                Console.WriteLine();

            }

            Console.WriteLine("Deseja remover um produto ao estoque ? ");
            Console.WriteLine("1 - Sim ");
            Console.WriteLine("2 - Não ");
            int remover = int.Parse(Console.ReadLine());
            if(remover == 1)
            {
                Console.WriteLine("Informe a quantidade que deseja remover:");
                int quantidadeRemovida = int.Parse(Console.ReadLine());
                produto.RemoverProdutoEmEstoque(quantidadeRemovida);
                Console.WriteLine("Dados do produto: " + produto);
                Console.WriteLine();

            }
            Console.WriteLine();
            Console.WriteLine("Programa finalizando 3...2...1");
        }

    }
}
