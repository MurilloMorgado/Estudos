using System;
using System.Globalization;

namespace Estudos.aulas.aula42
{
    internal class ControleDeEstoque
    {
        public void TotalEmEstoque()
        {

            Console.WriteLine("Informe os dados do produto");
            Console.Write("Digite o nome do produto: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o preço do produto " + nome + ":");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Digite a quantidade em estoque:");
            int quantidade = int.Parse(Console.ReadLine());

            Produto produto = new Produto(nome, preco, quantidade);
            
            Console.WriteLine("Dados do produto: " + produto);

            Console.WriteLine("Deseja adicionar um produto ao estoque ? ");
            Console.WriteLine("1 - Sim ");
            Console.WriteLine("2 - Não ");
            int adicionar = int.Parse(Console.ReadLine());
            Console.Clear();
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
            Console.Clear();
            if (remover == 1)
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
