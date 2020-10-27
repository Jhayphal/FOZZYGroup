using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Security;

namespace FOZZYGroup
{
	internal static class ExtensionMethods
	{
		/// <summary>
		/// Сохранить список работников в файл.
		/// </summary>
		/// <param name="path">Путь к файлу.</param>
		/// <returns>Список работников.</returns>
		/// <exception cref="ArgumentException">Параметр path является пустой строкой ("").</exception>
		/// <exception cref="ArgumentNullException">path имеет значение null.</exception>
		/// <exception cref="FileNotFoundException">Файл не найден.</exception>
		/// <exception cref="DirectoryNotFoundException">Указан недопустимый путь (например, он ведет на несопоставленный диск).</exception>
		/// <exception cref="PathTooLongException">Указанный путь, имя файла или оба значения превышают максимальную длину, заданную в системе.</exception>
		/// <exception cref="IOException">path содержит неправильный или недопустимый синтаксис имени файла, имени каталога или метки тома.</exception>
		/// <exception cref="SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="InvalidOperationException">Возникла ошибка при сериализации. Исходное исключение доступно с помощью свойства InnerException.</exception>
		public static void SaveToFile(this List<Employee> self, string path)
		{
			XmlSerializer serializer = new XmlSerializer(self.GetType());

			using(StreamWriter writer = new StreamWriter(path))
				serializer.Serialize(writer, self);
		}
	}
}
