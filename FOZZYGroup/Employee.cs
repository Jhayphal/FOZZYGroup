using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace FOZZYGroup
{
	/// <summary>
	/// Работник.
	/// </summary>
	[Serializable]
	[XmlInclude(typeof(HourlySalaryEmployee))]
	[XmlInclude(typeof(FixedSalaryEmployee))]
	public abstract class Employee : IComparable<Employee>
	{
		/// <summary>
		/// Имя.
		/// </summary>
		public string FirstName { get; set; }
		
		/// <summary>
		/// Фамилия.
		/// </summary>
		public string LastName { get; set; }
		
		/// <summary>
		/// Отчество.
		/// </summary>
		public string SurName { get; set; }

		/// <summary>
		/// Зарплата, инвариантная к виду оплаты.
		/// </summary>
		public decimal Salary { get; set; }

		/// <summary>
		/// Расчитать среднюю зароботную плату за месяц.
		/// </summary>
		/// <returns>Средняя зароботная плата за месяц.</returns>
		public abstract decimal CalcAverageMonthlySalary();

		public override string ToString()
		{
			string result = string.Empty;
			bool hasText = false;

			if (!string.IsNullOrWhiteSpace(FirstName))
			{
				result = FirstName;

				hasText = true;
			}

			if (!string.IsNullOrWhiteSpace(LastName))
			{
				if (hasText)
					result += " ";

				result += LastName;

				hasText = true;
			}

			if (!string.IsNullOrWhiteSpace(SurName))
			{
				if (hasText)
					result += " ";

				result += SurName;

				hasText = true;
			}

			var salary = CalcAverageMonthlySalary();

			if (salary != 0m)
			{
				if (hasText)
					result += ", ";

				result += salary.ToString("c");
			}

			return result;
		}

		public int CompareTo(Employee other)
		{
			if (other == null)
				return 1;

			decimal mySalary = CalcAverageMonthlySalary();
			decimal otherSalary = other.CalcAverageMonthlySalary();

			int result = mySalary.CompareTo(otherSalary);

			if (result != 0)
				return result;

			string otherText = other.ToString();

			return ToString().CompareTo(otherText);
		}

		/// <summary>
		/// Загрузить список работников из файла.
		/// </summary>
		/// <param name="path">Путь к файлу.</param>
		/// <returns>Список работников.</returns>
		/// <exception cref="ArgumentException">Параметр path является пустой строкой ("").</exception>
		/// <exception cref="ArgumentNullException">path имеет значение null.</exception>
		/// <exception cref="FileNotFoundException">Файл не найден.</exception>
		/// <exception cref="DirectoryNotFoundException">Указан недопустимый путь (например, он ведет на несопоставленный диск).</exception>
		/// <exception cref="IOException">path содержит неправильный или недопустимый синтаксис имени файла, имени каталога или метки тома.</exception>
		/// <exception cref="InvalidOperationException">Возникла ошибка при десериализации. Исходное исключение доступно с помощью свойства InnerException.</exception>
		public static List<Employee> LoadFromFile(string path)
		{
			XmlSerializer serializer = new XmlSerializer(typeof(List<Employee>));

			using(StreamReader reader = new StreamReader(path))
				return (List<Employee>)serializer.Deserialize(reader);
		}
	}
}
