using System;
using System.Globalization;


namespace ConsoleApp1 {
    internal class ContaBancaria {
        public int Numero { get; private set; } //propriedade autoimplementada
        public string Titular { get; set; } //propriedade autoimplementada
        public double Saldo { get; private set; } //propriedade autoimplementada com restrição de acesso

        public ContaBancaria(int numero, string titular) { //constructor 
            Numero = numero;
            Titular = titular;
            //_saldo = 0.0
        }

        public ContaBancaria(int numero, string titular, double saldo) : this(numero, titular) {
            Saldo = saldo;
             }

        void Deposito(double quantia) {
        }

        void Saque(double quantia) {

        }
          


        public override string ToString() {
            return "\nConta "
                + Numero
                + ", Titular: "
                + Titular
                + ",Saldo: $ "
                + Saldo.ToString("F2",CultureInfo.InvariantCulture);


        }
    }
}




