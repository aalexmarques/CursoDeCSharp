using System;
using System.Globalization;
using System.Collections.Generic;

namespace ModificadorDeParametros {
	public class Program {
		static void Main(string[] args) {
			List<string> list = new List<string>();

			list.Add("anna");
			list.Add("joao");
			list.Add("carlos");

			foreach( string i in list) {
				Console.WriteLine(i);
			}
		}
	}
}