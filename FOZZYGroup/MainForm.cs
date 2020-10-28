using System;
using System.Windows.Forms;
using FOZZYGroup.Controllers;
using FOZZYGroup.Providers;

namespace FOZZYGroup
{
	public partial class MainForm : Form
	{
		EmployeesController controller;

		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			controller = new EmployeesController();
			controller.OnUpdate += Controller_OnUpdate;

			controller.Fill(new SampleEmployeesProvider());
		}

		private void Controller_OnUpdate(object sender, EventArgs e)
		{
			RefreshItems();
		}

		void RefreshItems()
		{
			listBoxFirstFive.Items.Clear();
			listBoxFirstFive.Items.AddRange(controller.GetFirstFive());

			listBoxLastThree.Items.Clear();
			listBoxLastThree.Items.AddRange(controller.GetLastThree());
		}

		private void textBoxLoad_Click(object sender, EventArgs e)
		{
			if (controller.TryLoadFromFile(out string fileName))
				textBoxLoad.Text = fileName;
		}

		private void buttonSave_Click(object sender, EventArgs e)
		{
			if (controller.TrySaveToFile(out string fileName))
				MessageBox.Show($"Измения сохранены в файл \"{ fileName }\".", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}
