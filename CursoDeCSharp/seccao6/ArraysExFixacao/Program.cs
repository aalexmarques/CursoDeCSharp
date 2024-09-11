using System;
using System.Globalization;

namespace ArraysExFixacao {
    class Program {
        static void Main(string[] args) {
            Estudante[] array = new Estudante[10];
            Console.Write("Quantos quartos serao alugados? ");
            int nQuartos = int.Parse(Console.ReadLine());
            for (int i = 1; i <= nQuartos; i++) {
                Console.WriteLine($"\nAluger #{i}");

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                array[quarto] = new Estudante(nome, email);
            }
            Console.WriteLine("Quartos ocupados:");
            for (int i = 1; i < 10; i++) {
                if (array[i] != null) {
                    Console.WriteLine(i + ": " + array[i]);
                }
            }

        }

    }
}