using System;
using System.Globalization;

namespace exercicios2 {
    public class Funcionario {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido() { 
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double percentagem) {
            SalarioBruto += SalarioBruto * percentagem / 100.0;
        }
    }
}
