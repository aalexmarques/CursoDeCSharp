using System;
using System.Globalization;

/*
Você deve fazer um programa que realize o cadastro de uma conta, 
dando opção para que seja ou não informado o valor de depósito inicial. 
Em seguida, realizar um depósito e depois um saque, 
sempre mostrando os dados da conta após cada operação.
*/

namespace Banco {
    class Program
    {
        static void Main(string[] args) {

            ContaBancaria conta;

            Console.Write("Entre o num da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Havera depósito inicial (s/n)? ");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 's' || resp == 'S') { 
                Console.Write("Entre o valor de depósito inicial: ");
                double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, titular, deposito);
            } else { 
                conta = new ContaBancaria(numero, titular);
            }

            Console.WriteLine("\nDados da conta:");
            Console.WriteLine(conta);

            Console.Write("\nEntre um valor para deposito: "); 
            conta.depositarDinheiro(double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture));
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);

            Console.Write("\nEntre um valor de dinheiro para retirar: ");
            conta.retirarDinheiro(double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture));
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);

        }
    }
}