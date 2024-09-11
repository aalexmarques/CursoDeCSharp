using System;
using System.Globalization;

namespace exercicio3 { 
    class Program {
        static void Main(string[] args) {
            Aluno aluno; aluno = new Aluno();
            
            Console.WriteLine("Digite o nome do aluno");
            aluno.nome = Console.ReadLine();

            Console.WriteLine("Digite as tres notas do aluno");
            aluno.nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("NOTA FINAL = " + aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(aluno.Aprovado());


        }
    }
}

