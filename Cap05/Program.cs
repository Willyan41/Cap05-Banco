using System;
using System.Globalization;

namespace Cap05
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Entre com o número da conta: ");
            int conta = int.Parse(Console.ReadLine());

            Console.Write("Entre com o titular da conta: ");
            string NomeTitular = Console.ReadLine();

            ContaBancaria c = new ContaBancaria(conta, NomeTitular);


            Console.Write("Haverá depósito inicial (s/n)? ");
            char opcao = char.Parse(Console.ReadLine());

            if (opcao != null && opcao == 's' || opcao == 'S')
            {
                Console.Write("Entre o valor depósito inicial: ");
                c.Deposito(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
                Console.WriteLine();

            }
            Console.WriteLine("Dados da conta: \n" + c.ToString());
            Console.WriteLine();

            Console.Write("Entre com um valor para depósito: ");
            c.Deposito(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine("Dados da conta atualizados: \n" + c.ToString());


            Console.Write("Entre com um valor para saque: ");
            c.Saque(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine("Dados da conta atualizados: \n" + c.ToString());




        }
    }
}
