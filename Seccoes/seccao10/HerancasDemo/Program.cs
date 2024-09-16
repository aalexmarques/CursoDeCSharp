using HerancasDemo.Entities;
using System;

namespace HerancasDemo {
	class Program {
		static void Main(string[] args) {
			BusinessAccount businessAccount = new BusinessAccount(1010,"Alex",3000.50,1050.10);
			Console.WriteLine(businessAccount.Balance);
			businessAccount.Loan(1600);
			Console.WriteLine(businessAccount.Balance);

			
		}
	}
}