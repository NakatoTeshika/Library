namespace Library
{
	partial class Login
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
			this.logUserName = new System.Windows.Forms.TextBox();
			this.logPassword = new System.Windows.Forms.TextBox();
			this.UserName = new System.Windows.Forms.Label();
			this.Password = new System.Windows.Forms.Label();
			this.btnlogin = new System.Windows.Forms.Button();
			this.btnexit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// logUserName
			// 
			this.logUserName.Location = new System.Drawing.Point(180, 41);
			this.logUserName.Multiline = true;
			this.logUserName.Name = "logUserName";
			this.logUserName.Size = new System.Drawing.Size(181, 36);
			this.logUserName.TabIndex = 0;
			// 
			// logPassword
			// 
			this.logPassword.Location = new System.Drawing.Point(180, 110);
			this.logPassword.Multiline = true;
			this.logPassword.Name = "logPassword";
			this.logPassword.PasswordChar = '*';
			this.logPassword.Size = new System.Drawing.Size(181, 36);
			this.logPassword.TabIndex = 1;
			// 
			// UserName
			// 
			this.UserName.AutoSize = true;
			this.UserName.BackColor = System.Drawing.SystemColors.Control;
			this.UserName.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.UserName.Location = new System.Drawing.Point(46, 49);
			this.UserName.Name = "UserName";
			this.UserName.Size = new System.Drawing.Size(72, 28);
			this.UserName.TabIndex = 2;
			this.UserName.Text = "Логин";
			// 
			// Password
			// 
			this.Password.AutoSize = true;
			this.Password.BackColor = System.Drawing.SystemColors.Control;
			this.Password.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Password.Location = new System.Drawing.Point(46, 118);
			this.Password.Name = "Password";
			this.Password.Size = new System.Drawing.Size(85, 28);
			this.Password.TabIndex = 3;
			this.Password.Text = "Пароль";
			// 
			// btnlogin
			// 
			this.btnlogin.BackColor = System.Drawing.Color.Tan;
			this.btnlogin.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnlogin.Location = new System.Drawing.Point(215, 152);
			this.btnlogin.Name = "btnlogin";
			this.btnlogin.Size = new System.Drawing.Size(101, 41);
			this.btnlogin.TabIndex = 4;
			this.btnlogin.Text = "Войти";
			this.btnlogin.UseVisualStyleBackColor = false;
			this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
			// 
			// btnexit
			// 
			this.btnexit.BackColor = System.Drawing.Color.Tan;
			this.btnexit.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnexit.Location = new System.Drawing.Point(215, 199);
			this.btnexit.Name = "btnexit";
			this.btnexit.Size = new System.Drawing.Size(101, 41);
			this.btnexit.TabIndex = 6;
			this.btnexit.Text = "Выход";
			this.btnexit.UseVisualStyleBackColor = false;
			this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(400, 256);
			this.Controls.Add(this.btnexit);
			this.Controls.Add(this.btnlogin);
			this.Controls.Add(this.Password);
			this.Controls.Add(this.UserName);
			this.Controls.Add(this.logPassword);
			this.Controls.Add(this.logUserName);
			this.Name = "Login";
			this.Text = "Login";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox logUserName;
		private System.Windows.Forms.TextBox logPassword;
		private System.Windows.Forms.Label UserName;
		private System.Windows.Forms.Label Password;
		private System.Windows.Forms.Button btnlogin;
		private System.Windows.Forms.Button btnexit;
	}
}

