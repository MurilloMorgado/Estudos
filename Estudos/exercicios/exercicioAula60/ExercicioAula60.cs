using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Estudos.exercicios.exercicioAula60
{
    internal class ExercicioAula60
    {
        public void Banco()
        {
            ContaBancaria contaBancaria;

            Console.Write("Infome o número da conta: ");
            int conta = int.Parse(Console.ReadLine());

            Console.Write("Informe o titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá depósito iniciar (s/n)? ");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 's' || resp == 'S')
            {
                Console.Write("Informe o valor de depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                contaBancaria = new ContaBancaria(
                    conta,
                    titular,
                    depositoInicial
                    );
            }
            else
            {
                contaBancaria = new ContaBancaria(
                    conta,
                    titular
                    );
            }

            Console.WriteLine("Dados da conta :" + contaBancaria.ToString());
            Console.WriteLine();
            Console.Write("Informe um valor para depósito: ");
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            contaBancaria.Deposito(deposito);
            Console.WriteLine("Dados da conta Atualizada");
            Console.WriteLine(contaBancaria.ToString());
            Console.WriteLine();

            Console.Write("Informe um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            contaBancaria.Saque(saque);
            Console.WriteLine("Dados da conta Atualizada");
            Console.WriteLine(contaBancaria.ToString());
        }
    }
}
