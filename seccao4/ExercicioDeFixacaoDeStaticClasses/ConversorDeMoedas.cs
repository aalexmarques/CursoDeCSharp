using System;

namespace ExercicioDeFixacaoDeStaticClasses {
    internal class ConversorDeMoedas {
        public static double Iof = 6.0;

        public static double DolarParaEuro(double cotacao, double quantidade) {
            double total = cotacao * quantidade;
            return total + total * Iof / 100.0;
        }

    }
}
