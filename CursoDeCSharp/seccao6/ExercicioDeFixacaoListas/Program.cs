using System;
using System.Data.SqlTypes;
using System.Globalization;

namespace ExercicioDeFixacaoListas {
	class Program {
		static void Main(string[] args) {
			Console.Write("How many employees will be registered? ");
			int nEmployees = int.Parse(Console.ReadLine());

			List<Employee> employees = new List<Employee>();

			for (int i = 0; i < nEmployees; i++) {
				int j = i + 1;
				Console.WriteLine("Employee #" + j);
				Console.Write("Id: "); int id = int.Parse(Console.ReadLine());
				Console.Write("Name: "); string name = Console.ReadLine();
				Console.Write("Salary: "); double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
				employees.Add(new Employee(id, name, salary));
				Console.WriteLine();
			}
			Console.Write("Enter the employee id that will have a salary increase: ");
			int idFind = int.Parse(Console.ReadLine());

			Employee emp = employees.Find(x => x.Id == idFind);
			if (emp != null) {
				Console.Write("Enter the percentage: ");
				double percentage = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                emp.increaseSalary(percentage);
			}else {

				Console.WriteLine("The id does not exist!");
			}

			Console.WriteLine("\nUpdated list of employees:");
			foreach(Employee obj in employees) {
				Console.WriteLine(obj);
			}
		}



	}
}
