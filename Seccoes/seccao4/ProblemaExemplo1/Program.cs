using System;
using System.Globalization;
using ProblemaExemplo1;

namespace areaDeUmTriangulo {
    class Program {
        static void Main(string[] args) {
            double area;

            TrianguloClass x, y;

            x = new TrianguloClass(); //duas instancias da classe TrianguloClass , duas variaveis compostas
            y = new TrianguloClass();

            Console.WriteLine("Entre com as medidas do triangulo X:");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = AreaTriangulo(x.A, x.B, x.C);


            Console.WriteLine("Entre com as medidas do triangulo Y:");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Area de X = {area.ToString("F4", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Area de Y = {AreaTriangulo(y.A, y.B, y.C).ToString("F4", CultureInfo.InvariantCulture)}");

            if (area > AreaTriangulo(y.A, y.B, y.C)) {
                Console.WriteLine("Maior area: X");
            } else {
                Console.WriteLine("Maior area: Y");
            }
        }


        static double AreaTriangulo(double a, double b, double c) {
            double p = (a + b + c) / 2.0;

            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));

        }

    }
}