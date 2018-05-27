namespace Library
{
	partial class LMS
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.mastersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.roleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.publicHouseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.authorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.bookInRegisterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.bookOutRegisterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.отчетТекущегоСеансаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.оПриложенииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.public_houseTableAdapter1 = new Library.LibraryDateTableAdapters.Public_houseTableAdapter();
			this.отчетCrystalReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mastersToolStripMenuItem,
            this.inventoryToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.справкаToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(576, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// mastersToolStripMenuItem
			// 
			this.mastersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.roleToolStripMenuItem,
            this.publicHouseToolStripMenuItem,
            this.authorsToolStripMenuItem});
			this.mastersToolStripMenuItem.Name = "mastersToolStripMenuItem";
			this.mastersToolStripMenuItem.Size = new System.Drawing.Size(208, 20);
			this.mastersToolStripMenuItem.Text = "Таблицы и операции над книгами";
			// 
			// roleToolStripMenuItem
			// 
			this.roleToolStripMenuItem.Name = "roleToolStripMenuItem";
			this.roleToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
			this.roleToolStripMenuItem.Text = "Операции над книгами";
			this.roleToolStripMenuItem.Click += new System.EventHandler(this.roleToolStripMenuItem_Click);
			// 
			// publicHouseToolStripMenuItem
			// 
			this.publicHouseToolStripMenuItem.Name = "publicHouseToolStripMenuItem";
			this.publicHouseToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
			this.publicHouseToolStripMenuItem.Text = "Таблица издательств";
			this.publicHouseToolStripMenuItem.Click += new System.EventHandler(this.publicHouseToolStripMenuItem_Click);
			// 
			// authorsToolStripMenuItem
			// 
			this.authorsToolStripMenuItem.Name = "authorsToolStripMenuItem";
			this.authorsToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
			this.authorsToolStripMenuItem.Text = "Таблица авторов";
			this.authorsToolStripMenuItem.Click += new System.EventHandler(this.authorsToolStripMenuItem_Click);
			// 
			// inventoryToolStripMenuItem
			// 
			this.inventoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookInRegisterToolStripMenuItem,
            this.bookOutRegisterToolStripMenuItem});
			this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
			this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(143, 20);
			this.inventoryToolStripMenuItem.Text = "Выдача и возврат книг";
			// 
			// bookInRegisterToolStripMenuItem
			// 
			this.bookInRegisterToolStripMenuItem.Name = "bookInRegisterToolStripMenuItem";
			this.bookInRegisterToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
			this.bookInRegisterToolStripMenuItem.Text = "Выдача";
			this.bookInRegisterToolStripMenuItem.Click += new System.EventHandler(this.bookInRegisterToolStripMenuItem_Click);
			// 
			// bookOutRegisterToolStripMenuItem
			// 
			this.bookOutRegisterToolStripMenuItem.Name = "bookOutRegisterToolStripMenuItem";
			this.bookOutRegisterToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
			this.bookOutRegisterToolStripMenuItem.Text = "Возврат";
			this.bookOutRegisterToolStripMenuItem.Click += new System.EventHandler(this.bookOutRegisterToolStripMenuItem_Click);
			// 
			// searchToolStripMenuItem
			// 
			this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
			this.searchToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
			this.searchToolStripMenuItem.Text = "Поиск";
			this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
			// 
			// справкаToolStripMenuItem
			// 
			this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отчетТекущегоСеансаToolStripMenuItem,
            this.оПриложенииToolStripMenuItem,
            this.отчетCrystalReportToolStripMenuItem});
			this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
			this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
			this.справкаToolStripMenuItem.Text = "Справка";
			// 
			// отчетТекущегоСеансаToolStripMenuItem
			// 
			this.отчетТекущегоСеансаToolStripMenuItem.Name = "отчетТекущегоСеансаToolStripMenuItem";
			this.отчетТекущегоСеансаToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
			this.отчетТекущегоСеансаToolStripMenuItem.Text = "Отчет текущего сеанса";
			this.отчетТекущегоСеансаToolStripMenuItem.Click += new System.EventHandler(this.отчетТекущегоСеансаToolStripMenuItem_Click);
			// 
			// оПриложенииToolStripMenuItem
			// 
			this.оПриложенииToolStripMenuItem.Name = "оПриложенииToolStripMenuItem";
			this.оПриложенииToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
			this.оПриложенииToolStripMenuItem.Text = "О приложении";
			this.оПриложенииToolStripMenuItem.Click += new System.EventHandler(this.оПриложенииToolStripMenuItem_Click);
			// 
			// public_houseTableAdapter1
			// 
			this.public_houseTableAdapter1.ClearBeforeFill = true;
			// 
			// отчетCrystalReportToolStripMenuItem
			// 
			this.отчетCrystalReportToolStripMenuItem.Name = "отчетCrystalReportToolStripMenuItem";
			this.отчетCrystalReportToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
			this.отчетCrystalReportToolStripMenuItem.Text = "Отчет CrystalReport";
			this.отчетCrystalReportToolStripMenuItem.Click += new System.EventHandler(this.отчетCrystalReportToolStripMenuItem_Click);
			// 
			// LMS
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(576, 305);
			this.Controls.Add(this.menuStrip1);
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "LMS";
			this.Text = "LMS";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LMS_FormClosed);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem mastersToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem roleToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem bookInRegisterToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem bookOutRegisterToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem publicHouseToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem authorsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
		private LibraryDateTableAdapters.Public_houseTableAdapter public_houseTableAdapter1;
		private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem отчетТекущегоСеансаToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem оПриложенииToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem отчетCrystalReportToolStripMenuItem;
	}
}