using System;

namespace FOZZYGroup
{
	/// <summary>
	/// Работник с почасовой оплатой труда.
	/// </summary>
	public class HourlySalaryEmployee : Employee
	{
		/// <summary>
		/// Коэфициент для расчета зарплаты.
		/// </summary>
		const decimal Factor = 20.8m;

		/// <summary>
		/// Количество часов в смене.
		/// </summary>
		const decimal WorkHours = 8m;

		public override decimal CalcAverageMonthlySalary()
		{
			return Salary * WorkHours * Factor;
		}
	}
}
