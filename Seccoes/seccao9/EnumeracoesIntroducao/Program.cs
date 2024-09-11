﻿using EnumeracoesIntroducao.Entities;
using EnumeracoesIntroducao.Entities.Enums;
using System;

namespace EnumeracoesIntroducao {
	class Program {
		static void Main(string[] args) {
			Order order = new Order() {
				Id = 1080,
				Moment = DateTime.Now,
				Status = OrderStatus.PendingPayment
			};
	
			Console.WriteLine(order);

			string txt = OrderStatus.PendingPayment.ToString();

			OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

			Console.WriteLine(txt);
			Console.WriteLine(os);
			Console.WriteLine(txt);

		}
	}
}