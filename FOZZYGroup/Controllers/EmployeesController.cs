using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FOZZYGroup.Providers;
using FOZZYGroup.Types;
using FOZZYGroup.Extensions;

namespace FOZZYGroup.Controllers
{
	internal class EmployeesController
	{
		public event EventHandler OnUpdate;

		const string FilesFilter = "Xml files (*.xml)|*.xml|All files (*.*)|*.*";

		protected List<Employee> employees;

		protected List<Employee> Employees
		{
			get => employees;
			set
			{
				employees = value;

				Update();
			}
		}

		public void Fill(IEmployeesProvider employeesProvider)
		{
			Employees = employeesProvider.GetEmployees().ToList();
		}

		public void Update()
		{
			try
			{
				if (employees == null)
					return;

				employees.Sort();
				employees.Reverse();
			}
			finally
			{
				OnUpdate?.Invoke(this, EventArgs.Empty);
			}
		}

		public Employee[] GetFirstFive()
		{
			return employees?
				.Take(5)
				.ToArray();
		}

		public Employee[] GetLastThree()
		{
			return employees?
				.Skip(employees.Count - 3)
				.ToArray();
		}

		public bool TryLoadFromFile(out string fileName)
		{
			fileName = null;
			
			using (OpenFileDialog dialog = new OpenFileDialog
			{
				Filter = FilesFilter,
				FilterIndex = 1,
				RestoreDirectory = true,
				CheckFileExists = true,
				CheckPathExists = true
			})
			{
				if (dialog.ShowDialog() != DialogResult.OK)
					return false;

				fileName = dialog.FileName;

				try
				{
					Employees = Employee.LoadFromFile(fileName);
				}
				catch(Exception e)
				{
					ShowError(e);

					return false;
				}
			}

			return true;
		}

		public bool TrySaveToFile(out string fileName)
		{
			fileName = null;

			using(SaveFileDialog dialog = new SaveFileDialog
			{
				Filter = FilesFilter,
				FilterIndex = 1,
				RestoreDirectory = true,
				AddExtension = true,
				DefaultExt = "xml"
			})
			{
				if (dialog.ShowDialog() != DialogResult.OK)
					return false;

				fileName = dialog.FileName;

				try
				{
					employees.SaveToFile(fileName);
				}
				catch(Exception e)
				{
					ShowError(e);

					return false;
				}
			}

			return true;
		}

		void ShowError(Exception e)
		{
			var errorText = GetFullExceptionMessage(e);

			MessageBox.Show(errorText, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		string GetFullExceptionMessage(Exception e)
		{
			if (e == null)
				return string.Empty;

			if (e.InnerException == null)
				return e.Message;

			return e.Message + Environment.NewLine + GetFullExceptionMessage(e.InnerException);
		}
	}
}
