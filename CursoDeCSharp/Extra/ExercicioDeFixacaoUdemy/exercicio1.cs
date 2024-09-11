using System;
using System.Globalization;

namespace Exercicio1 {
    class Program {
        static void Main(string[] args) {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1}, cujo preço é $ {preco1:2F}");
            Console.WriteLine($"Mesa de escritório, cujo preco é $ {preco2}");
            Console.WriteLine();
            Console.WriteLine($"Registro {idade} anos de idade, codigo {codigo} e gênero: {genero}");
            Console.WriteLine();
            Console.WriteLine($"Medida com oito casas decimais: {medida:F8}");
            Console.WriteLine($"Arredondado (três casas decimais): {medida:F3}");
            Console.WriteLine($"Separador com invariant culutre: {medida.ToString(CultureInfo.InvariantCulture)}");
        }
    }
}