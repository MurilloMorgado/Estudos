using System;
using System.Globalization;

namespace Estudos.aulas.aula70
{
    internal class Aula70
    {
        public void CalcularMediaDosProdutos()
        {
            
            Console.Write("Infrme a quantidade de produto: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto[] produtos = new Produto[quantidade];
            for (int i = 0; i < quantidade; i++)
            {
                string? nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Produto produto = new Produto(nome, preco);
                produtos[i] = produto;
            }

            double soma = 0;
            for (int i = 0; i < quantidade; i++)
            {
                soma += produtos[i].preco;
            }

            double resultado = Produto.CalcularMediaDePreco(soma, quantidade);

            Console.WriteLine("A media dos preços é: " +  resultado.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
