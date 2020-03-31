using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Cap05
{
    class ContaBancaria
    {
        public int NumeroConta { get; private set; }
        public string NomeTitular { get; set; }
        public double ValorConta { get; private set; }

        public ContaBancaria(int numeroConta, string nomeTitular)
        {
            NumeroConta = numeroConta;
            NomeTitular = nomeTitular;
        }

        public ContaBancaria(int numeroConta, string nomeTitular, double valorConta) : this(numeroConta, nomeTitular)
        {
            ValorConta = valorConta;

        }
        
        public void Deposito(double deposito)
        {
            ValorConta = ValorConta + deposito;
        }

        public int PegarConta(int pegarconta)
        {
            NumeroConta = pegarconta;

            return NumeroConta;
        }

        public void Saque(double saque)
        {
            if (ValorConta != null && ValorConta >= saque)
            {
                ValorConta = ValorConta - saque - 5.00;
            }
            else
            {
                Console.WriteLine("Não possui saldo suficiente para esta operação.");
            }
        }

        public string ToString()
        {
            return "Conta " +
                NumeroConta
                + ", Titular: " +
                NomeTitular
                + ", Possui o saldo de R$" +
                ValorConta.ToString("F2", CultureInfo.InvariantCulture);

        }

    }
}
