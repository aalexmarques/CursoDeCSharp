using System;
using System.Globalization;


namespace StockDeProdutos {
    internal class Program {
        static void Main(string[] args) {

            Produto p = new Produto();
            Console.WriteLine("Entre os dados do produto");

  //-------------------------------------------------------------------------------------------

            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();

            Console.Write("Preco: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.Write("Quantidade de Stock: ");
            p.Quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

  //-------------------------------------------------------------------------------------------

            Console.Write("\nDigite o numero de Produto a ser adicionado ao stock: ");

            p.AdicionarProdutos(int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine("Dados atualizados " + p);

 //--------------------------------------------------------------------------------------------
 
            Console.Write("\nDigite o numero de Produto a ser removido do stock: ");
            
            p.RemoverProdutos(int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine("Dados atualizados " + p);




        }
    }
}