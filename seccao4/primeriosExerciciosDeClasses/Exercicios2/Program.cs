using System;
using System.Globalization;
using Exercicios2;

namespace Exercicios2 {
    class Program {
        static void Main(string[] args) {
            double mediaDeSalario;
            Funcionarios f1, f2;
            f1 = new Funcionarios();
            f2 = new Funcionarios();

            Console.WriteLine("Dados do 1º Funcionario");
            Console.Write("Nome: ");
            f1.Nome = Console.ReadLine();
            Console.Write("Salario: ");
            f1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados da 2º funcionario:");
            Console.Write("Nome: ");
            f2.Nome = Console.ReadLine();
            Console.Write("Salario: ");
            f2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            mediaDeSalario = (f1.Salario + f2.Salario) / 2;
            Console.WriteLine("O Salário Médio é: " + mediaDeSalario.ToString("F2", CultureInfo.InvariantCulture));

        }

    }
}
