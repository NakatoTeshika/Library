using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace Library
{
	public partial class Login : Form
	{
		public Login()
		{
			InitializeComponent();
		}

		

		private void btnexit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnlogin_Click(object sender, EventArgs e)
		{
			OracleConnection orc = new OracleConnection(@"DATA SOURCE=localhost:1521/XE;PERSIST SECURITY INFO=True;USER ID=SHIN; Password = 123 ");
			OracleDataAdapter orada = new OracleDataAdapter("Select Count(*) from \"Librarian\" where Name = '" + logUserName.Text + "' and Librarian_ID = '" + logPassword.Text + "'",orc);
			DataTable dt = new DataTable();
			orada.Fill(dt);
			if (dt.Rows[0][0].ToString() == "1")
			{
				LMS lms = new LMS();
				lms.Show();
				this.Hide();
			}
			else
			{
				MessageBox.Show("Please Check your Username and Password");
			}
		}
	}
}
