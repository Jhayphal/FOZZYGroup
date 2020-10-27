using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FOZZYGroup
{
	internal class EmployeesController
	{
		const string FilesFilter = "Xml files (*.xml)|*.xml|All files (*.*)|*.*";

		List<Employee> employees;

		public EmployeesController()
		{
			employees = SampleEmployeesProvider.GetEmployees().ToList();

			Update();
		}

		public void Update()
		{
			employees.Sort();
			employees.Reverse();
		}

		public Employee[] GetFirstFive()
		{
			return employees
				.Take(5)
				.ToArray();
		}

		public Employee[] GetLastThree()
		{
			return employees
				.Skip(employees.Count - 3)
				.ToArray();
		}

		public bool TryLoadFromFile(out string fileName)
		{
			fileName = null;
			
			OpenFileDialog dialog = new OpenFileDialog
			{
				Filter = FilesFilter,
				FilterIndex = 2,
				RestoreDirectory = true,
				CheckFileExists = true,
				CheckPathExists = true
			};

			if (dialog.ShowDialog() != DialogResult.OK)
				return false;

			fileName = dialog.FileName;

			try
			{
				employees = Employee.LoadFromFile(fileName);
			}
			catch(Exception e)
			{
				ShowError(e);

				return false;
			}

			Update();

			return true;
		}

		public bool TrySaveToFile(out string fileName)
		{
			fileName = null;

			SaveFileDialog dialog = new SaveFileDialog
			{
				Filter = FilesFilter,
				FilterIndex = 2,
				RestoreDirectory = true,
				AddExtension = true,
				DefaultExt = "xml"
			};

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
