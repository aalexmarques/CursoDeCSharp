using System;
using System.Globalization;

namespace Course {
    class Program {
        static void Main(string[] args) {
            int idade = 20;
            double saldo = 10.32323;
            string nome = "Joana";
            Console.WriteLine("{0} tem {1} anos e tem uma bounty de {2:F2} Euros", nome, idade, saldo);

            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais");

            Console.WriteLine("A " + nome + " tem " + idade + " anos e tem " + saldo.ToString("F2" , CultureInfo.InvariantCulture) + " a seu nome" );

        }
    }
}

