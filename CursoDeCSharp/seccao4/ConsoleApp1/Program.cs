using System;
using System.Globalization;

namespace ConsoleApp1 {
    class Program {
         static void Main(string[] args) {

            ContaBancaria conta;

            Console.Write("Entre o numero da Conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre o Titular da Conta: ");
            string titular = Console.ReadLine();
            Console.Write("Havera déposito incial (s/n)?: ");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 's' || resp == 'S') {
                Console.Write("Entre o valor de depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, titular, depositoInicial);
            }
            else {
                conta = new ContaBancaria(numero, titular);

               
            }
            Console.WriteLine("\nDados da Conta: ");
        }
    }
}