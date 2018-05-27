namespace Library
{
	partial class AuthorsList
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
			this.authorBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.authorTableAdapter = new Library.LibraryDateTableAdapters.AuthorTableAdapter();
			this.aUTHORIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sURNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pATRONYMICDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.libraryDate)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.authorBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aUTHORIDDataGridViewTextBoxColumn,
            this.sURNAMEDataGridViewTextBoxColumn,
            this.nAMEDataGridViewTextBoxColumn,
            this.pATRONYMICDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.authorBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(0, 0);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(447, 150);
			this.dataGridView1.TabIndex = 0;
			// 
			// libraryDate
			// 
			this.libraryDate.DataSetName = "LibraryDate";
			this.libraryDate.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// authorBindingSource
			// 
			this.authorBindingSource.DataMember = "Author";
			this.authorBindingSource.DataSource = this.libraryDate;
			// 
			// authorTableAdapter
			// 
			this.authorTableAdapter.ClearBeforeFill = true;
			// 
			// aUTHORIDDataGridViewTextBoxColumn
			// 
			this.aUTHORIDDataGridViewTextBoxColumn.DataPropertyName = "AUTHOR_ID";
			this.aUTHORIDDataGridViewTextBoxColumn.HeaderText = "AUTHOR_ID";
			this.aUTHORIDDataGridViewTextBoxColumn.Name = "aUTHORIDDataGridViewTextBoxColumn";
			// 
			// sURNAMEDataGridViewTextBoxColumn
			// 
			this.sURNAMEDataGridViewTextBoxColumn.DataPropertyName = "SURNAME";
			this.sURNAMEDataGridViewTextBoxColumn.HeaderText = "SURNAME";
			this.sURNAMEDataGridViewTextBoxColumn.Name = "sURNAMEDataGridViewTextBoxColumn";
			// 
			// nAMEDataGridViewTextBoxColumn
			// 
			this.nAMEDataGridViewTextBoxColumn.DataPropertyName = "NAME";
			this.nAMEDataGridViewTextBoxColumn.HeaderText = "NAME";
			this.nAMEDataGridViewTextBoxColumn.Name = "nAMEDataGridViewTextBoxColumn";
			// 
			// pATRONYMICDataGridViewTextBoxColumn
			// 
			this.pATRONYMICDataGridViewTextBoxColumn.DataPropertyName = "PATRONYMIC";
			this.pATRONYMICDataGridViewTextBoxColumn.HeaderText = "PATRONYMIC";
			this.pATRONYMICDataGridViewTextBoxColumn.Name = "pATRONYMICDataGridViewTextBoxColumn";
			// 
			// AuthorsList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(445, 149);
			this.Controls.Add(this.dataGridView1);
			this.Name = "AuthorsList";
			this.Text = "AuthorsList";
			this.Load += new System.EventHandler(this.AuthorsList_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.libraryDate)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.authorBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private LibraryDate libraryDate;
		private System.Windows.Forms.BindingSource authorBindingSource;
		private LibraryDateTableAdapters.AuthorTableAdapter authorTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn aUTHORIDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn sURNAMEDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn pATRONYMICDataGridViewTextBoxColumn;
	}
}