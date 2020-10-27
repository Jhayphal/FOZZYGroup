namespace FOZZYGroup
{
	partial class MainForm
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.groupBoxFirstFive = new System.Windows.Forms.GroupBox();
			this.listBoxFirstFive = new System.Windows.Forms.ListBox();
			this.groupBoxLastThree = new System.Windows.Forms.GroupBox();
			this.listBoxLastThree = new System.Windows.Forms.ListBox();
			this.textBoxLoad = new System.Windows.Forms.TextBox();
			this.labelLoad = new System.Windows.Forms.Label();
			this.buttonSave = new System.Windows.Forms.Button();
			this.groupBoxFirstFive.SuspendLayout();
			this.groupBoxLastThree.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBoxFirstFive
			// 
			this.groupBoxFirstFive.Controls.Add(this.listBoxFirstFive);
			this.groupBoxFirstFive.Location = new System.Drawing.Point(12, 12);
			this.groupBoxFirstFive.Name = "groupBoxFirstFive";
			this.groupBoxFirstFive.Size = new System.Drawing.Size(339, 426);
			this.groupBoxFirstFive.TabIndex = 0;
			this.groupBoxFirstFive.TabStop = false;
			this.groupBoxFirstFive.Text = "Первые пять";
			// 
			// listBoxFirstFive
			// 
			this.listBoxFirstFive.FormattingEnabled = true;
			this.listBoxFirstFive.Location = new System.Drawing.Point(6, 19);
			this.listBoxFirstFive.Name = "listBoxFirstFive";
			this.listBoxFirstFive.Size = new System.Drawing.Size(327, 394);
			this.listBoxFirstFive.TabIndex = 0;
			// 
			// groupBoxLastThree
			// 
			this.groupBoxLastThree.Controls.Add(this.listBoxLastThree);
			this.groupBoxLastThree.Location = new System.Drawing.Point(357, 12);
			this.groupBoxLastThree.Name = "groupBoxLastThree";
			this.groupBoxLastThree.Size = new System.Drawing.Size(339, 426);
			this.groupBoxLastThree.TabIndex = 1;
			this.groupBoxLastThree.TabStop = false;
			this.groupBoxLastThree.Text = "Последние три";
			// 
			// listBoxLastThree
			// 
			this.listBoxLastThree.FormattingEnabled = true;
			this.listBoxLastThree.Location = new System.Drawing.Point(6, 19);
			this.listBoxLastThree.Name = "listBoxLastThree";
			this.listBoxLastThree.Size = new System.Drawing.Size(327, 394);
			this.listBoxLastThree.TabIndex = 0;
			// 
			// textBoxLoad
			// 
			this.textBoxLoad.Cursor = System.Windows.Forms.Cursors.Hand;
			this.textBoxLoad.Location = new System.Drawing.Point(713, 50);
			this.textBoxLoad.Name = "textBoxLoad";
			this.textBoxLoad.ReadOnly = true;
			this.textBoxLoad.Size = new System.Drawing.Size(224, 20);
			this.textBoxLoad.TabIndex = 2;
			this.textBoxLoad.Click += new System.EventHandler(this.textBoxLoad_Click);
			// 
			// labelLoad
			// 
			this.labelLoad.AutoSize = true;
			this.labelLoad.Location = new System.Drawing.Point(710, 34);
			this.labelLoad.Name = "labelLoad";
			this.labelLoad.Size = new System.Drawing.Size(112, 13);
			this.labelLoad.TabIndex = 3;
			this.labelLoad.Text = "Загрузить из файла:";
			// 
			// buttonSave
			// 
			this.buttonSave.Location = new System.Drawing.Point(713, 76);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(224, 24);
			this.buttonSave.TabIndex = 4;
			this.buttonSave.Text = "Сохранить в файл";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(949, 450);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.labelLoad);
			this.Controls.Add(this.textBoxLoad);
			this.Controls.Add(this.groupBoxLastThree);
			this.Controls.Add(this.groupBoxFirstFive);
			this.Name = "MainForm";
			this.Text = "Задание №1";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.groupBoxFirstFive.ResumeLayout(false);
			this.groupBoxLastThree.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBoxFirstFive;
		private System.Windows.Forms.ListBox listBoxFirstFive;
		private System.Windows.Forms.GroupBox groupBoxLastThree;
		private System.Windows.Forms.ListBox listBoxLastThree;
		private System.Windows.Forms.TextBox textBoxLoad;
		private System.Windows.Forms.Label labelLoad;
		private System.Windows.Forms.Button buttonSave;
	}
}

