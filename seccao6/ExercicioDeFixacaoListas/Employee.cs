using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioDeFixacaoListas {
    public class Employee {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; private set; }

        public Employee(int id, string name, double salary) {
            this.Id = id;
            this.Name = name;
            this.Salary = salary;
        }

        public void increaseSalary(double percentage) {
            Salary += Salary * percentage / 100.0;
        }

        public override string ToString() {
            return $"{Id}, {Name}, {Salary.ToString("F2",CultureInfo.InvariantCulture)}";
        }
    }
}
