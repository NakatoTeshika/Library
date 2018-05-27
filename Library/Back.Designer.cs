namespace Library
{
	partial class Back
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Back));
			this.cmbExtradition = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtReservation = new System.Windows.Forms.TextBox();
			this.txtCode = new System.Windows.Forms.TextBox();
			this.txtStorage = new System.Windows.Forms.TextBox();
			this.txtReader = new System.Windows.Forms.TextBox();
			this.txtLibrarian = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// cmbExtradition
			// 
			this.cmbExtradition.FormattingEnabled = true;
			this.cmbExtradition.Location = new System.Drawing.Point(272, 58);
			this.cmbExtradition.Name = "cmbExtradition";
			this.cmbExtradition.Size = new System.Drawing.Size(176, 21);
			this.cmbExtradition.TabIndex = 0;
			this.cmbExtradition.SelectedIndexChanged += new System.EventHandler(this.cmbExtradition_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(310, 34);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(104, 22);
			this.label1.TabIndex = 1;
			this.label1.Text = "Выдача_ID";
			// 
			// txtReservation
			// 
			this.txtReservation.Location = new System.Drawing.Point(186, 101);
			this.txtReservation.Name = "txtReservation";
			this.txtReservation.Size = new System.Drawing.Size(154, 20);
			this.txtReservation.TabIndex = 2;
			// 
			// txtCode
			// 
			this.txtCode.Location = new System.Drawing.Point(186, 144);
			this.txtCode.Name = "txtCode";
			this.txtCode.Size = new System.Drawing.Size(154, 20);
			this.txtCode.TabIndex = 3;
			// 
			// txtStorage
			// 
			this.txtStorage.Location = new System.Drawing.Point(186, 184);
			this.txtStorage.Name = "txtStorage";
			this.txtStorage.Size = new System.Drawing.Size(154, 20);
			this.txtStorage.TabIndex = 4;
			// 
			// txtReader
			// 
			this.txtReader.Location = new System.Drawing.Point(531, 101);
			this.txtReader.Name = "txtReader";
			this.txtReader.Size = new System.Drawing.Size(132, 20);
			this.txtReader.TabIndex = 5;
			// 
			// txtLibrarian
			// 
			this.txtLibrarian.Location = new System.Drawing.Point(531, 144);
			this.txtLibrarian.Name = "txtLibrarian";
			this.txtLibrarian.Size = new System.Drawing.Size(132, 20);
			this.txtLibrarian.TabIndex = 6;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(12, 99);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(168, 22);
			this.label2.TabIndex = 8;
			this.label2.Text = "Резервирование_ID";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 144);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(94, 22);
			this.label3.TabIndex = 9;
			this.label3.Text = "Код книги";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(12, 180);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(119, 22);
			this.label4.TabIndex = 10;
			this.label4.Text = "Хранение_ID";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(367, 98);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(128, 22);
			this.label5.TabIndex = 11;
			this.label5.Text = "Читатель_ID";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(367, 144);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(158, 22);
			this.label6.TabIndex = 12;
			this.label6.Text = "Библиотекарь_ID";
			// 
			// dateTimePicker
			// 
			this.dateTimePicker.Location = new System.Drawing.Point(406, 205);
			this.dateTimePicker.Name = "dateTimePicker";
			this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
			this.dateTimePicker.TabIndex = 13;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(443, 180);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(133, 22);
			this.label7.TabIndex = 14;
			this.label7.Text = "Дата возврата";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label8.Location = new System.Drawing.Point(279, 1);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(165, 33);
			this.label8.TabIndex = 16;
			this.label8.Text = "Возврат книг";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Tan;
			this.button1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.button1.Location = new System.Drawing.Point(289, 246);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(155, 39);
			this.button1.TabIndex = 15;
			this.button1.Text = "Добавить";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Back
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(684, 313);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.dateTimePicker);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtLibrarian);
			this.Controls.Add(this.txtReader);
			this.Controls.Add(this.txtStorage);
			this.Controls.Add(this.txtCode);
			this.Controls.Add(this.txtReservation);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cmbExtradition);
			this.Name = "Back";
			this.Text = "Back";
			this.Load += new System.EventHandler(this.Back_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cmbExtradition;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtReservation;
		private System.Windows.Forms.TextBox txtCode;
		private System.Windows.Forms.TextBox txtStorage;
		private System.Windows.Forms.TextBox txtReader;
		private System.Windows.Forms.TextBox txtLibrarian;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DateTimePicker dateTimePicker;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button button1;
	}
}