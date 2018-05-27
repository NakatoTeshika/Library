namespace Library
{
	partial class ListOfPublicHouse
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
			this.components = new System.ComponentModel.Container();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.libraryDate = new Library.LibraryDate();
			this.libraryDateBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.publichouseBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.public_houseTableAdapter = new Library.LibraryDateTableAdapters.Public_houseTableAdapter();
			this.cHIPERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cITYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.aDRESSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pHONEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.iSBNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.libraryDate)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.libraryDateBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.publichouseBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToOrderColumns = true;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cHIPERDataGridViewTextBoxColumn,
            this.nAMEDataGridViewTextBoxColumn,
            this.cITYDataGridViewTextBoxColumn,
            this.aDRESSDataGridViewTextBoxColumn,
            this.pHONEDataGridViewTextBoxColumn,
            this.iSBNDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.publichouseBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(0, 0);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(644, 150);
			this.dataGridView1.TabIndex = 0;
			// 
			// libraryDate
			// 
			this.libraryDate.DataSetName = "LibraryDate";
			this.libraryDate.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// libraryDateBindingSource
			// 
			this.libraryDateBindingSource.DataSource = this.libraryDate;
			this.libraryDateBindingSource.Position = 0;
			// 
			// publichouseBindingSource
			// 
			this.publichouseBindingSource.DataMember = "Public_house";
			this.publichouseBindingSource.DataSource = this.libraryDate;
			// 
			// public_houseTableAdapter
			// 
			this.public_houseTableAdapter.ClearBeforeFill = true;
			// 
			// cHIPERDataGridViewTextBoxColumn
			// 
			this.cHIPERDataGridViewTextBoxColumn.DataPropertyName = "CHIPER";
			this.cHIPERDataGridViewTextBoxColumn.HeaderText = "CHIPER";
			this.cHIPERDataGridViewTextBoxColumn.Name = "cHIPERDataGridViewTextBoxColumn";
			// 
			// nAMEDataGridViewTextBoxColumn
			// 
			this.nAMEDataGridViewTextBoxColumn.DataPropertyName = "NAME";
			this.nAMEDataGridViewTextBoxColumn.HeaderText = "NAME";
			this.nAMEDataGridViewTextBoxColumn.Name = "nAMEDataGridViewTextBoxColumn";
			// 
			// cITYDataGridViewTextBoxColumn
			// 
			this.cITYDataGridViewTextBoxColumn.DataPropertyName = "CITY";
			this.cITYDataGridViewTextBoxColumn.HeaderText = "CITY";
			this.cITYDataGridViewTextBoxColumn.Name = "cITYDataGridViewTextBoxColumn";
			// 
			// aDRESSDataGridViewTextBoxColumn
			// 
			this.aDRESSDataGridViewTextBoxColumn.DataPropertyName = "ADRESS";
			this.aDRESSDataGridViewTextBoxColumn.HeaderText = "ADRESS";
			this.aDRESSDataGridViewTextBoxColumn.Name = "aDRESSDataGridViewTextBoxColumn";
			// 
			// pHONEDataGridViewTextBoxColumn
			// 
			this.pHONEDataGridViewTextBoxColumn.DataPropertyName = "PHONE";
			this.pHONEDataGridViewTextBoxColumn.HeaderText = "PHONE";
			this.pHONEDataGridViewTextBoxColumn.Name = "pHONEDataGridViewTextBoxColumn";
			// 
			// iSBNDataGridViewTextBoxColumn
			// 
			this.iSBNDataGridViewTextBoxColumn.DataPropertyName = "ISBN";
			this.iSBNDataGridViewTextBoxColumn.HeaderText = "ISBN";
			this.iSBNDataGridViewTextBoxColumn.Name = "iSBNDataGridViewTextBoxColumn";
			// 
			// ListOfPublicHouse
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(643, 149);
			this.Controls.Add(this.dataGridView1);
			this.Name = "ListOfPublicHouse";
			this.Text = "ListOfPublicHouse";
			this.Load += new System.EventHandler(this.ListOfPublicHouse_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.libraryDate)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.libraryDateBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.publichouseBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.BindingSource libraryDateBindingSource;
		private LibraryDate libraryDate;
		private System.Windows.Forms.BindingSource publichouseBindingSource;
		private LibraryDateTableAdapters.Public_houseTableAdapter public_houseTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn cHIPERDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn cITYDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn aDRESSDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn pHONEDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn iSBNDataGridViewTextBoxColumn;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.ComponentModel.BackgroundWorker backgroundWorker2;
	}
}