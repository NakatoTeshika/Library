namespace Library
{
	partial class Search
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search));
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.btnSearch = new System.Windows.Forms.Button();
			this.grid_Author_Book = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.grid_Author_Book)).BeginInit();
			this.SuspendLayout();
			// 
			// txtSearch
			// 
			this.txtSearch.Location = new System.Drawing.Point(25, 12);
			this.txtSearch.Multiline = true;
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(620, 43);
			this.txtSearch.TabIndex = 0;
			// 
			// btnSearch
			// 
			this.btnSearch.BackColor = System.Drawing.Color.White;
			this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnSearch.ForeColor = System.Drawing.Color.Transparent;
			this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
			this.btnSearch.Location = new System.Drawing.Point(667, 10);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(51, 45);
			this.btnSearch.TabIndex = 1;
			this.btnSearch.UseVisualStyleBackColor = false;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// grid_Author_Book
			// 
			this.grid_Author_Book.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grid_Author_Book.Location = new System.Drawing.Point(25, 73);
			this.grid_Author_Book.Name = "grid_Author_Book";
			this.grid_Author_Book.Size = new System.Drawing.Size(620, 253);
			this.grid_Author_Book.TabIndex = 2;
			// 
			// Search
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(749, 338);
			this.Controls.Add(this.grid_Author_Book);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.txtSearch);
			this.Name = "Search";
			this.Text = "Search";
			this.Load += new System.EventHandler(this.Search_Load);
			((System.ComponentModel.ISupportInitialize)(this.grid_Author_Book)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.DataGridView grid_Author_Book;
	}
}