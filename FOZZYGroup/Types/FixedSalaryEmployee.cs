using System;

namespace FOZZYGroup.Types
{
	/// <summary>
	/// Работник с фиксированной заработной платой.
	/// </summary>
	public class FixedSalaryEmployee : Employee
	{
		public override decimal CalcAverageMonthlySalary()
		{
			return Salary;
		}
	}
}
