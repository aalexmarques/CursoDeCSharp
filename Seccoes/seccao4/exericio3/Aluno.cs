using System;
using System.ComponentModel.Design;
using System.Globalization;

namespace exercicio3 {
    public class Aluno {
        public string nome;
        public double nota1;
        public double nota2;
        public double nota3;

        public double NotaFinal() {
            return nota1 + nota2 + nota3;
        }

        public string Aprovado() {
            if (NotaFinal() >= 60.0) {
                return "\nAPROVADO";
            } else {

                return "\nREPROVADO \nFALTARAM " + ((60 - NotaFinal()).ToString("F2",CultureInfo.InvariantCulture)) + " PONTOS";
            }

        }
    }
}
