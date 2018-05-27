namespace Library
{
	partial class Books
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Books));
			this.gridBooks = new System.Windows.Forms.DataGridView();
			this.libraryDate = new Library.LibraryDate();
			this.btnUpdateBook = new System.Windows.Forms.Button();
			this.btnDeleteBook = new System.Windows.Forms.Button();
			this.literatureTableAdapter = new Library.LibraryDateTableAdapters.LiteratureTableAdapter();
			this.btnAddBook = new System.Windows.Forms.Button();
			this.viewTableAdapter = new Library.LibraryDateTableAdapters.ViewTableAdapter();
			this.categoryTableAdapter = new Library.LibraryDateTableAdapters.CategoryTableAdapter();
			this.libraryDate1 = new Library.LibraryDate();
			this.public_houseTableAdapter = new Library.LibraryDateTableAdapters.Public_houseTableAdapter();
			this.bindingTableAdapter = new Library.LibraryDateTableAdapters.BindingTableAdapter();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.txtPagesCount = new System.Windows.Forms.TextBox();
			this.txtCountBook = new System.Windows.Forms.TextBox();
			this.txtYearBook = new System.Windows.Forms.TextBox();
			this.txtPriceBook = new System.Windows.Forms.TextBox();
			this.txtNameBook = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.cmbView = new System.Windows.Forms.ComboBox();
			this.viewBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.cmbBind = new System.Windows.Forms.ComboBox();
			this.bindingBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.cmbCategory = new System.Windows.Forms.ComboBox();
			this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.cmbPubHouse = new System.Windows.Forms.ComboBox();
			this.publichouseBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.cmbStorage = new System.Windows.Forms.ComboBox();
			this.storageBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.storageTableAdapter = new Library.LibraryDateTableAdapters.StorageTableAdapter();
			this.txtID = new System.Windows.Forms.TextBox();
			this.publichouseBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.categoryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.publichouseBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
			this.literatureBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.libraryDateBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.gridBooks)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.libraryDate)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.libraryDate1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.viewBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.publichouseBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.storageBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.publichouseBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.publichouseBindingSource2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.literatureBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.libraryDateBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// gridBooks
			// 
			this.gridBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridBooks.Location = new System.Drawing.Point(571, 25);
			this.gridBooks.Name = "gridBooks";
			this.gridBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gridBooks.Size = new System.Drawing.Size(438, 353);
			this.gridBooks.TabIndex = 0;
			this.gridBooks.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gridBooks_MouseClick);
			this.gridBooks.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridBooks_MouseClick);
			// 
			// libraryDate
			// 
			this.libraryDate.DataSetName = "LibraryDate";
			this.libraryDate.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// btnUpdateBook
			// 
			this.btnUpdateBook.BackColor = System.Drawing.Color.BurlyWood;
			this.btnUpdateBook.Location = new System.Drawing.Point(711, 402);
			this.btnUpdateBook.Name = "btnUpdateBook";
			this.btnUpdateBook.Size = new System.Drawing.Size(134, 46);
			this.btnUpdateBook.TabIndex = 2;
			this.btnUpdateBook.Text = "Изменить";
			this.btnUpdateBook.UseVisualStyleBackColor = false;
			this.btnUpdateBook.Click += new System.EventHandler(this.btnUpdateBook_Click);
			// 
			// btnDeleteBook
			// 
			this.btnDeleteBook.BackColor = System.Drawing.Color.Wheat;
			this.btnDeleteBook.Location = new System.Drawing.Point(844, 402);
			this.btnDeleteBook.Name = "btnDeleteBook";
			this.btnDeleteBook.Size = new System.Drawing.Size(134, 46);
			this.btnDeleteBook.TabIndex = 3;
			this.btnDeleteBook.Text = "Удалить";
			this.btnDeleteBook.UseVisualStyleBackColor = false;
			this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
			// 
			// literatureTableAdapter
			// 
			this.literatureTableAdapter.ClearBeforeFill = true;
			// 
			// btnAddBook
			// 
			this.btnAddBook.BackColor = System.Drawing.Color.Peru;
			this.btnAddBook.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnAddBook.Location = new System.Drawing.Point(571, 402);
			this.btnAddBook.Name = "btnAddBook";
			this.btnAddBook.Size = new System.Drawing.Size(134, 46);
			this.btnAddBook.TabIndex = 1;
			this.btnAddBook.Text = "Добавить";
			this.btnAddBook.UseVisualStyleBackColor = false;
			this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
			// 
			// viewTableAdapter
			// 
			this.viewTableAdapter.ClearBeforeFill = true;
			// 
			// categoryTableAdapter
			// 
			this.categoryTableAdapter.ClearBeforeFill = true;
			// 
			// libraryDate1
			// 
			this.libraryDate1.DataSetName = "LibraryDate";
			this.libraryDate1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// public_houseTableAdapter
			// 
			this.public_houseTableAdapter.ClearBeforeFill = true;
			// 
			// bindingTableAdapter
			// 
			this.bindingTableAdapter.ClearBeforeFill = true;
			// 
			// txtDescription
			// 
			this.txtDescription.Location = new System.Drawing.Point(113, 275);
			this.txtDescription.Multiline = true;
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new System.Drawing.Size(452, 103);
			this.txtDescription.TabIndex = 43;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label11.Location = new System.Drawing.Point(12, 275);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(83, 20);
			this.label11.TabIndex = 42;
			this.label11.Text = "Описание";
			// 
			// txtPagesCount
			// 
			this.txtPagesCount.Location = new System.Drawing.Point(383, 25);
			this.txtPagesCount.Multiline = true;
			this.txtPagesCount.Name = "txtPagesCount";
			this.txtPagesCount.Size = new System.Drawing.Size(182, 28);
			this.txtPagesCount.TabIndex = 40;
			// 
			// txtCountBook
			// 
			this.txtCountBook.Location = new System.Drawing.Point(101, 166);
			this.txtCountBook.Multiline = true;
			this.txtCountBook.Name = "txtCountBook";
			this.txtCountBook.Size = new System.Drawing.Size(182, 28);
			this.txtCountBook.TabIndex = 39;
			// 
			// txtYearBook
			// 
			this.txtYearBook.Location = new System.Drawing.Point(101, 119);
			this.txtYearBook.Multiline = true;
			this.txtYearBook.Name = "txtYearBook";
			this.txtYearBook.Size = new System.Drawing.Size(182, 28);
			this.txtYearBook.TabIndex = 38;
			// 
			// txtPriceBook
			// 
			this.txtPriceBook.Location = new System.Drawing.Point(101, 72);
			this.txtPriceBook.Multiline = true;
			this.txtPriceBook.Name = "txtPriceBook";
			this.txtPriceBook.Size = new System.Drawing.Size(182, 28);
			this.txtPriceBook.TabIndex = 37;
			// 
			// txtNameBook
			// 
			this.txtNameBook.Location = new System.Drawing.Point(101, 23);
			this.txtNameBook.Multiline = true;
			this.txtNameBook.Name = "txtNameBook";
			this.txtNameBook.Size = new System.Drawing.Size(182, 28);
			this.txtNameBook.TabIndex = 36;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label10.Location = new System.Drawing.Point(289, 173);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(83, 20);
			this.label10.TabIndex = 35;
			this.label10.Text = "Хранение";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label9.Location = new System.Drawing.Point(12, 225);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(89, 20);
			this.label9.TabIndex = 34;
			this.label9.Text = "Категория";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label8.Location = new System.Drawing.Point(289, 222);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(120, 20);
			this.label8.TabIndex = 33;
			this.label8.Text = "Издательство";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label7.Location = new System.Drawing.Point(289, 124);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(85, 20);
			this.label7.TabIndex = 32;
			this.label7.Text = "Переплет";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(289, 80);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(40, 20);
			this.label6.TabIndex = 31;
			this.label6.Text = "Вид";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(289, 31);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(95, 20);
			this.label5.TabIndex = 30;
			this.label5.Text = "Кол-во стр.";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(12, 174);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(61, 20);
			this.label4.TabIndex = 29;
			this.label4.Text = "Кол-во";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(12, 127);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(74, 20);
			this.label3.TabIndex = 28;
			this.label3.Text = "Год изд.";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(12, 78);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 20);
			this.label2.TabIndex = 27;
			this.label2.Text = "Цена";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(12, 33);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(83, 20);
			this.label1.TabIndex = 26;
			this.label1.Text = "Название";
			// 
			// cmbView
			// 
			this.cmbView.DataSource = this.viewBindingSource;
			this.cmbView.DisplayMember = "NAME";
			this.cmbView.FormattingEnabled = true;
			this.cmbView.Location = new System.Drawing.Point(383, 77);
			this.cmbView.Name = "cmbView";
			this.cmbView.Size = new System.Drawing.Size(182, 21);
			this.cmbView.TabIndex = 44;
			this.cmbView.ValueMember = "VIEW_ID";
			// 
			// viewBindingSource
			// 
			this.viewBindingSource.DataMember = "View";
			this.viewBindingSource.DataSource = this.libraryDate1;
			// 
			// cmbBind
			// 
			this.cmbBind.DataSource = this.bindingBindingSource;
			this.cmbBind.DisplayMember = "TYPE";
			this.cmbBind.FormattingEnabled = true;
			this.cmbBind.Location = new System.Drawing.Point(383, 123);
			this.cmbBind.Name = "cmbBind";
			this.cmbBind.Size = new System.Drawing.Size(182, 21);
			this.cmbBind.TabIndex = 45;
			this.cmbBind.ValueMember = "BINDING_ID";
			// 
			// bindingBindingSource
			// 
			this.bindingBindingSource.DataMember = "Binding";
			this.bindingBindingSource.DataSource = this.libraryDate1;
			// 
			// cmbCategory
			// 
			this.cmbCategory.DataSource = this.categoryBindingSource;
			this.cmbCategory.DisplayMember = "NAME";
			this.cmbCategory.FormattingEnabled = true;
			this.cmbCategory.Location = new System.Drawing.Point(101, 224);
			this.cmbCategory.Name = "cmbCategory";
			this.cmbCategory.Size = new System.Drawing.Size(182, 21);
			this.cmbCategory.TabIndex = 46;
			this.cmbCategory.ValueMember = "CATEGORY_ID";
			// 
			// categoryBindingSource
			// 
			this.categoryBindingSource.DataMember = "Category";
			this.categoryBindingSource.DataSource = this.libraryDate1;
			// 
			// cmbPubHouse
			// 
			this.cmbPubHouse.DataSource = this.publichouseBindingSource;
			this.cmbPubHouse.DisplayMember = "NAME";
			this.cmbPubHouse.FormattingEnabled = true;
			this.cmbPubHouse.Location = new System.Drawing.Point(415, 221);
			this.cmbPubHouse.Name = "cmbPubHouse";
			this.cmbPubHouse.Size = new System.Drawing.Size(150, 21);
			this.cmbPubHouse.TabIndex = 47;
			this.cmbPubHouse.ValueMember = "CHIPER";
			// 
			// publichouseBindingSource
			// 
			this.publichouseBindingSource.DataMember = "Public_house";
			this.publichouseBindingSource.DataSource = this.libraryDate1;
			// 
			// cmbStorage
			// 
			this.cmbStorage.DataSource = this.storageBindingSource;
			this.cmbStorage.DisplayMember = "SECTION";
			this.cmbStorage.FormattingEnabled = true;
			this.cmbStorage.Location = new System.Drawing.Point(383, 172);
			this.cmbStorage.Name = "cmbStorage";
			this.cmbStorage.Size = new System.Drawing.Size(182, 21);
			this.cmbStorage.TabIndex = 48;
			this.cmbStorage.ValueMember = "STORAGE_ID";
			// 
			// storageBindingSource
			// 
			this.storageBindingSource.DataMember = "Storage";
			this.storageBindingSource.DataSource = this.libraryDate;
			// 
			// storageTableAdapter
			// 
			this.storageTableAdapter.ClearBeforeFill = true;
			// 
			// txtID
			// 
			this.txtID.Enabled = false;
			this.txtID.Location = new System.Drawing.Point(984, 416);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(26, 20);
			this.txtID.TabIndex = 49;
			// 
			// publichouseBindingSource1
			// 
			this.publichouseBindingSource1.DataMember = "Public_house";
			this.publichouseBindingSource1.DataSource = this.libraryDate;
			// 
			// categoryBindingSource1
			// 
			this.categoryBindingSource1.DataMember = "Category";
			this.categoryBindingSource1.DataSource = this.libraryDate;
			// 
			// publichouseBindingSource2
			// 
			this.publichouseBindingSource2.DataMember = "Public_house";
			this.publichouseBindingSource2.DataSource = this.libraryDate;
			// 
			// literatureBindingSource
			// 
			this.literatureBindingSource.DataMember = "Literature";
			this.literatureBindingSource.DataSource = this.libraryDate;
			// 
			// libraryDateBindingSource
			// 
			this.libraryDateBindingSource.DataSource = this.libraryDate;
			this.libraryDateBindingSource.Position = 0;
			// 
			// Books
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(1021, 534);
			this.Controls.Add(this.txtID);
			this.Controls.Add(this.cmbStorage);
			this.Controls.Add(this.cmbPubHouse);
			this.Controls.Add(this.cmbCategory);
			this.Controls.Add(this.cmbBind);
			this.Controls.Add(this.cmbView);
			this.Controls.Add(this.txtDescription);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.txtPagesCount);
			this.Controls.Add(this.txtCountBook);
			this.Controls.Add(this.txtYearBook);
			this.Controls.Add(this.txtPriceBook);
			this.Controls.Add(this.txtNameBook);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnDeleteBook);
			this.Controls.Add(this.btnUpdateBook);
			this.Controls.Add(this.btnAddBook);
			this.Controls.Add(this.gridBooks);
			this.Name = "Books";
			this.Text = "Books";
			this.Load += new System.EventHandler(this.Books_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridBooks)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.libraryDate)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.libraryDate1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.viewBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.publichouseBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.storageBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.publichouseBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.publichouseBindingSource2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.literatureBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.libraryDateBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView gridBooks;
		private System.Windows.Forms.Button btnUpdateBook;
		private System.Windows.Forms.Button btnDeleteBook;
		private LibraryDate libraryDate;
		private LibraryDateTableAdapters.LiteratureTableAdapter literatureTableAdapter;
		private System.Windows.Forms.Button btnAddBook;
		private LibraryDateTableAdapters.ViewTableAdapter viewTableAdapter;
		private LibraryDateTableAdapters.CategoryTableAdapter categoryTableAdapter;
		private LibraryDate libraryDate1;
		private LibraryDateTableAdapters.Public_houseTableAdapter public_houseTableAdapter;
		private LibraryDateTableAdapters.BindingTableAdapter bindingTableAdapter;
		private System.Windows.Forms.TextBox txtDescription;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox txtPagesCount;
		private System.Windows.Forms.TextBox txtCountBook;
		private System.Windows.Forms.TextBox txtYearBook;
		private System.Windows.Forms.TextBox txtPriceBook;
		private System.Windows.Forms.TextBox txtNameBook;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cmbView;
		private System.Windows.Forms.ComboBox cmbBind;
		private System.Windows.Forms.ComboBox cmbCategory;
		private System.Windows.Forms.ComboBox cmbPubHouse;
		private System.Windows.Forms.ComboBox cmbStorage;
		private LibraryDateTableAdapters.StorageTableAdapter storageTableAdapter;
		private System.Windows.Forms.TextBox txtID;
		private System.Windows.Forms.BindingSource viewBindingSource;
		private System.Windows.Forms.BindingSource bindingBindingSource;
		private System.Windows.Forms.BindingSource categoryBindingSource;
		private System.Windows.Forms.BindingSource publichouseBindingSource;
		private System.Windows.Forms.BindingSource storageBindingSource;
		private System.Windows.Forms.BindingSource publichouseBindingSource1;
		private System.Windows.Forms.BindingSource categoryBindingSource1;
		private System.Windows.Forms.BindingSource publichouseBindingSource2;
		private System.Windows.Forms.BindingSource literatureBindingSource;
		private System.Windows.Forms.BindingSource libraryDateBindingSource;
	}
}