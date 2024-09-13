using ExercicioPropostoEnumsComposicao.Entities;
using ExercicioPropostoEnumsComposicao.Entities.Enums;
using System;
using System.Globalization;

namespace ExercicioPropostoEnumsComposicao {
	class Program {
		static void Main(string[] args) {
			Console.WriteLine("Enter client data:");
			Console.Write("Name: ");
			string name = Console.ReadLine();
			Console.Write("Email: ");
			string email = Console.ReadLine();
			Console.Write("Birth date (DD/MM/YYYY) ");
			DateTime bDay = DateTime.Parse(Console.ReadLine());
			Console.WriteLine("\nEnter order data: ");
			Console.Write("Status: ");
			OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client client = new Client(name, email, bDay);
            Order order = new Order(DateTime.Now,status,client);

            Console.Write("How many times to this order? ");
			int n = int.Parse(Console.ReadLine());
			for (int i = 1; i <= n; i++) {
				Console.WriteLine($"Enter #{i} item data");
				Console.Write("Product name: ");
				string itemName = Console.ReadLine();
				Console.Write("Product Price: ");
				double itemPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Product product = new Product(itemName,itemPrice);

                Console.Write("Quantity: ");
				int quant = int.Parse(Console.ReadLine());
				
				OrderItem item = new OrderItem(quant,itemPrice,product);

				order.addItem(item);

			}



			Console.WriteLine("\nORDER SUMMARY:");
			Console.WriteLine(order);
		}
	}
}