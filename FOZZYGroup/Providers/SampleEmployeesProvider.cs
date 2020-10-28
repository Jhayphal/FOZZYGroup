using System.Collections.Generic;
using FOZZYGroup.Types;

namespace FOZZYGroup.Providers
{
	internal class SampleEmployeesProvider : IEmployeesProvider
	{
		public IEnumerable<Employee> GetEmployees()
		{
			return new List<Employee>
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
		}
	}
}
