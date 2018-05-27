using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
	public partial class Search : Form
	{

		OracleConnection orc = new OracleConnection(@"DATA SOURCE=localhost:1521/XE;PERSIST SECURITY INFO=True;USER ID=SHIN; Password = 123 ");
		OracleCommand oracmd;
		OracleDataAdapter adapter;
		DataTable table;
		public Search()
		{
			InitializeComponent();
		}
		public void populateDGV()
		{
			string selectQuery = "Select a.Surname,a.Name,a.Patronymic, l.Number_of_Copies, l.Name from \"Author\" a join  \"Literature_Author\" la on a.Author_ID = la.Author_ID join \"Literature\" l on la.Code = l.Code";
		
			table = new DataTable();
			adapter = new OracleDataAdapter(selectQuery, orc);
			adapter.Fill(table);
			grid_Author_Book.DataSource = table;
		}

		private void Search_Load(object sender, EventArgs e)
		{
			populateDGV();
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			adapter = new OracleDataAdapter("Select a.Surname,a.Name,a.Patronymic, l.Number_of_Copies, l.Name from \"Author\" a join  \"Literature_Author\" la on a.Author_ID = la.Author_ID join \"Literature\" l on la.Code = l.Code where a.Surname like '" + txtSearch.Text + "%' ", orc);
			OracleDataAdapter adapter1 = new OracleDataAdapter("Select a.Surname,a.Name,a.Patronymic, l.Number_of_Copies, l.Name from \"Author\" a join  \"Literature_Author\" la on a.Author_ID = la.Author_ID join \"Literature\" l on la.Code = l.Code where l.Name like '" + txtSearch.Text + "%'",orc);
			table = new DataTable();
			adapter.Fill(table);

			adapter1.Fill(table);
			grid_Author_Book.DataSource = table;
			//string searchQuery = "Select a.Surname,a.Name,a.Patronymic, l.Number_of_Copies, l.Name from \"Author\" a join  \"Literature_Author\" la on a.Author_ID = la.Author_ID join \"Literature\" l on la.Code = l.Code where a.Name like '%" +txtSearch.Text;
			//executeMyQuery(searchQuery);
			//populateDGV();
		}
		public void openConnection()
		{
			if (orc.State == ConnectionState.Closed)
			{
				orc.Open();
			}
		}
		public void closeConnection()
		{
			if (orc.State == ConnectionState.Open)
			{
				orc.Close();
			}
		}
		public void executeMyQuery(string query)
		{
			try
			{
				openConnection();
				oracmd = new OracleCommand(query, orc);
				if (oracmd.ExecuteNonQuery() == 1)
				{
					MessageBox.Show("Query EXecuted");
				}
				else
				{
					MessageBox.Show("Query non EXecuted");
				}

			}
			catch (Exception exp)
			{
				MessageBox.Show(exp.Message);
			}
			finally
			{
				closeConnection();
			}
		}
	}
}
