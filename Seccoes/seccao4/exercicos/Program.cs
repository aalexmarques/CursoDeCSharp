using System;
using exercicios;
using System.Globalization;

namespace exercicios {
    class Program {
        static void Main(string[] args) {

            Retangulo ret = new Retangulo(); // declarar e incializar;

            Console.WriteLine("Entre a Largura e Altura do retangulo:");

            ret.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            ret.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Area = " + ret.Area().ToString("F2"), CultureInfo.InvariantCulture);
            Console.WriteLine("Perimetro = " + ret.Perimetro().ToString("F2"), CultureInfo.InvariantCulture);
            Console.WriteLine("Diagonal = " + ret.Diagonal().ToString("F2"), CultureInfo.InvariantCulture);
        }
    }
}