using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudos.exercicios.exercicioAula60
{
    internal class ContaBancaria
    {
        public int NumeroConta { get; private set; }
        private string _nome;
        public double Saldo { get; private set; }



        public ContaBancaria(int numeroConta, string nome)
        {
            _nome = nome;
            NumeroConta = numeroConta;
        }

        public ContaBancaria(int numeroConta, string nome, double depositoInicial) : this(numeroConta, nome)
        {
            Deposito(depositoInicial);
        }

        public void Deposito(double depoisto)
        {
            Saldo += depoisto;
        }

        public void Saque(double saque)
        {
            double taxa = 5;
            Saldo -= (saque + taxa);
        }

        public override string ToString()
        {
            return "Conta"
                + NumeroConta
                + ", Titular: "
                + _nome
                + ", Saldo: $"
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
