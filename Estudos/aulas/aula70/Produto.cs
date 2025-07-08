using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudos.aulas.aula70
{
    internal class Produto
    {
        public string? nome;
        public double preco;

        public Produto(string? nome, double preco)
        {
            this.nome = nome;
            this.preco = preco;
        }

        public static double CalcularMediaDePreco(double preco, int quantidade)
        {
            return preco/quantidade;
        }
    }
}
