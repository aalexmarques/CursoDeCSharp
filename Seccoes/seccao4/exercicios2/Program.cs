using System;
using System.Globalization;
using exercicios2;

namespace exercicios2 { 
    class Program {
        static void Main(string[] args) {
            Funcionario f;
            f = new Funcionario();
            
            Console.Write("Nome: ");
            f.Nome = Console.ReadLine();

            Console.Write("Salario bruto: ");
            f.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Funcionario: " + f.Nome + ", $ " + f.SalarioLiquido().ToString("F2",CultureInfo.InvariantCulture));
            Console.Write("Digite a percentagem para aumentar o slario: ");
            double pecentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            f.AumentarSalario(pecentagem);

            Console.WriteLine("Dados atualizados: " + f.Nome + ", $ " + f.SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
