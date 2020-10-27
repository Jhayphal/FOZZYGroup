using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace FOZZYGroup
{
	internal class SampleEmployeesProvider
	{
		static readonly ReadOnlyCollection<Employee> employees;

		SampleEmployeesProvider() { }

		static SampleEmployeesProvider()
		{
			var temp = new List<Employee>
			{
				new FixedSalaryEmployee
				{
					FirstName = "Никита", 
					LastName = "Иванов", 
					SurName = "Петрович",
					Salary = 60000m
				},
				new HourlySalaryEmployee
				{
					FirstName = "Иван", 
					LastName = "Иванов", 
					SurName = "Иванович",
					Salary = 808.8m
				},
				new FixedSalaryEmployee
				{
					FirstName = "Никита", 
					LastName = "Петров", 
					SurName = "Петрович",
					Salary = 60000m
				},
				new FixedSalaryEmployee
				{
					FirstName = "Иван", 
					LastName = "Иванов", 
					SurName = "Иванович",
					Salary = 9722.5m
				},
				new FixedSalaryEmployee
				{
					FirstName = "Иван", 
					LastName = "Иванов", 
					SurName = "Иванович",
					Salary = 9000m
				},
				new HourlySalaryEmployee
				{
					FirstName = "Иван", 
					LastName = "Иванов", 
					SurName = "Иванович",
					Salary = 800m
				},
			};

			employees = temp.AsReadOnly();
		}

		public static ReadOnlyCollection<Employee> GetEmployees()
		{
			return employees;
		}
	}
}
