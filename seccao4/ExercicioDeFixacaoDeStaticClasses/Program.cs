using System;
using System.Globalization;

namespace ExercicioDeFixacaoDeStaticClasses {
    class Program {
        static void Main(string[] args) {
            double dolar, quantidade;
            Console.Write("Qual e a cotacao do dolar? ");
            dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dolares voce vai comprar? ");
            quantidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Valor a ser pago em reais = " + ConversorDeMoedas.DolarParaEuro(dolar, quantidade).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}