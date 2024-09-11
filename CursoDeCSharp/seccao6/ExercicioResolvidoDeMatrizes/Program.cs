using System;
using System.Globalization;

namespace ExercicioResolvidoDeMatrizes {
	class Program {
		static void Main(string[] args) {
			
			Console.WriteLine("Digite o num de linhas M e o num de colunas N respetivamente:");
			
			string[] line = Console.ReadLine().Split(' ');
			
			int n, m; //m linhas, n colunas
            m = int.Parse(line[0]);
            n = int.Parse(line[1]);

			int[,] matriz = new int[m, n];

			Console.WriteLine("Escreva o conteudo da matriz respetivo às linhas e colunas");

			for (int i = 0; i < m; i++) {
				string[] values = Console.ReadLine().Split();
				for (int j = 0; j < n; j++) {
					matriz[i,j] = int.Parse(values[j]);
				}
			}
			Console.WriteLine("Escreva um numero inteiro que ocorra na matriz:");
			int numDaMatriz = int.Parse(Console.ReadLine());

			for (int i = 0; i < m; i++) {
				for (int j = 0; j < n; j++) {
					if (numDaMatriz == matriz[i, j]) {
						Console.WriteLine("Position " + i + "," + j + ":");
						if (j > 0) {
							Console.WriteLine("Left: " + matriz[i, j - 1]);
						}
						if (i > 0) {
							Console.WriteLine("Up: " + matriz[i - 1,j]);
						}
						if (j < n - 1) {
							Console.WriteLine("Right: " + matriz[i, j+1]);
						}
						if (i < m -1 ) {
							Console.WriteLine("Down: " + matriz[i +1, j]);
						}
					}
				}
			}

		}
	}
}
