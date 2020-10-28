using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FOZZYGroup.Types;

namespace FOZZYGroup.Providers
{
	internal interface IEmployeesProvider
	{
		IEnumerable<Employee> GetEmployees();
	}
}
