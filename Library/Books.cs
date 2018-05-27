using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using System.Configuration;

namespace Library
{
	public partial class Books : Form
	{
		OracleConnection orc = new OracleConnection(@"DATA SOURCE=localhost:1521/XE;PERSIST SECURITY INFO=True;USER ID=SHIN; Password = 123 ");
		OracleCommand oracmd;
		private const String STOREDPROCEDURENAME = "SHIN.LITERATUR_INSERT";
		private const String CODE= "CODE";
		private const String FIELD1_PARM = "NAME";
		private const String FIELD2_PARM = "YEAR_OF_PUBLISHING";
		private const String FIELD3_PARM = "PRICE";
		private const String FIELD4_PARM = "NUMBER_OF_COPIES";
		private const String FIELD5_PARM = "NUMBER_OF_PAGES";
		private const String FIELD6_PARM = "DESCRIPTION";
		private const String FIELD7_PARM = "CHIPER";
		private const String FIELD8_PARM = "VIEW_ID";
		private const String FIELD9_PARM = "CATEGORY_ID";
		private const String FIELD10_PARM = "BINDING_ID";
		private const String FIELD11_PARM = "STORAGE_ID";
		OracleDataAdapter adapter;
		DataTable table;
		//private const String FIELD12_PARM = "YEAR_OF_PUBLISHING";
		//OracleCommand orcmd;
		public Books()
		{
			//this.setConnection();
			InitializeComponent();
		}
		/*	private void updateDataGrid()
			{
				OracleCommand cmd = orc.CreateCommand();
				cmd.CommandText = "SELECT * FROM \"LITERATURE\" ORDER BY NAME";
				cmd.CommandType = CommandType.Text;
				OracleDataReader dr = cmd.ExecuteReader();
				DataTable dt = new DataTable();
				dt.Load(dr);
				gridBooks.ItemsSource = 
			}*/
		private void btnAddBook_Click(object sender, EventArgs e)
		{
			//	string insertQuery = "INSERT INTO \"Literature\"(CODE, NAME, YEAR_OF_PUBLISHING, PRICE, NUMBER_OF_COPIES, NUMBER_OF_PAGES, DESCRIPTION, CHIPER, VIEW_ID, CATEGORY_ID, BINDING_ID, STORAGE_ID) VALUES (\"Literature_seq.NEXTVALUE\",'" + txtNameBook.Text+ "', '" + txtYearBook.Text + "','" + txtPriceBook.Text + "','" + txtCountBook.Text + "','" + txtPagesCount.Text + "','" + txtDescription.Text + "','" + cmbPubHouse.Text + "','" + cmbView.Text + "','" + cmbCategory.Text + "','" + cmbView.Text + "','" + cmbStorage.Text + "')";
			//executeMyQuery(insertQuery);
			//OracleCommand oracmd = orc.CreateCommand();
			//orcmd.CommandText = sql_stmt;
			//orcmd.CommandType = CommandType.Text;
			//orcmd.Parameters.Add = ("CODE", OracleDbType.Int32,6).V
		

		// Stored procedure parameter name constants for table
	


		OracleCommand orcmd = new OracleCommand();
			orcmd.Connection = orc;
			orcmd.CommandText = STOREDPROCEDURENAME;
            orcmd.CommandType = CommandType.StoredProcedure;
// Add the parameters and set values for them.
          orcmd.Parameters.Add(CODE, OracleDbType.Int32).Direction =
				ParameterDirection.Output;
			orcmd.Parameters.Add(FIELD1_PARM, OracleDbType.Varchar2, 50);
			orcmd.Parameters.Add(FIELD2_PARM, OracleDbType.Int32);
			orcmd.Parameters.Add(FIELD3_PARM, OracleDbType.Int32);
			orcmd.Parameters.Add(FIELD4_PARM, OracleDbType.Int32);
			orcmd.Parameters.Add(FIELD5_PARM, OracleDbType.Int32);
			orcmd.Parameters.Add(FIELD6_PARM, OracleDbType.Varchar2, 250);
			orcmd.Parameters.Add(FIELD7_PARM, OracleDbType.Int32);
			orcmd.Parameters.Add(FIELD8_PARM, OracleDbType.Int32);
			orcmd.Parameters.Add(FIELD9_PARM, OracleDbType.Int32);
			orcmd.Parameters.Add(FIELD10_PARM, OracleDbType.Int32);
			orcmd.Parameters.Add(FIELD11_PARM, OracleDbType.Int32);
			//orcmd.Parameters.Add(FIELD5_PARM, OracleDbType.Int32);
			orcmd.Parameters[FIELD1_PARM].Value = txtNameBook.Text;
			orcmd.Parameters[FIELD2_PARM].Value = txtYearBook.Text;
			orcmd.Parameters[FIELD3_PARM].Value = txtPriceBook.Text;
			orcmd.Parameters[FIELD4_PARM].Value = txtCountBook.Text;
			orcmd.Parameters[FIELD5_PARM].Value = txtPagesCount.Text;
			orcmd.Parameters[FIELD6_PARM].Value = txtDescription.Text;
			orcmd.Parameters[FIELD7_PARM].Value = cmbPubHouse.SelectedValue;
			orcmd.Parameters[FIELD8_PARM].Value = cmbView.SelectedValue;
			orcmd.Parameters[FIELD9_PARM].Value = cmbCategory.SelectedValue;
			orcmd.Parameters[FIELD10_PARM].Value = cmbBind.SelectedValue;
			orcmd.Parameters[FIELD11_PARM].Value = cmbStorage.SelectedValue;
			
			// Execute the insert query.
			orc.Open( );
try
{
    orcmd.ExecuteNonQuery( );
}
catch(Exception ex)
{
    MessageBox.Show(ex.Message, "Retrieving Oracle Sequence Values",
        MessageBoxButtons.OK, MessageBoxIcon.Error);
    return;
}
finally
{
    orc.Close( );
}
			populateDGV();
// Retrieve and display the sequence value.
//int sequenceValue = (int)orcmd.Parameters[CODE].Value;
//MessageBox.Show("Inserted record with ID = " + sequenceValue,
   // "Retrieving Oracle Sequence Values", MessageBoxButtons.OK,
    //MessageBoxIcon.Information);

		}
	
		private void Books_Load(object sender, EventArgs e)
		{
			populateDGV();
			//cc();
			// TODO: данная строка кода позволяет загрузить данные в таблицу "libraryDate.Storage". При необходимости она может быть перемещена или удалена.
		this.storageTableAdapter.Fill(this.libraryDate.Storage);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "libraryDate1.View". При необходимости она может быть перемещена или удалена.
			this.viewTableAdapter.Fill(this.libraryDate1.View);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "libraryDate1.Category". При необходимости она может быть перемещена или удалена.
			this.categoryTableAdapter.Fill(this.libraryDate1.Category);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "libraryDate1.Public_house". При необходимости она может быть перемещена или удалена.
			this.public_houseTableAdapter.Fill(this.libraryDate1.Public_house);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "libraryDate1.Binding". При необходимости она может быть перемещена или удалена.
			this.bindingTableAdapter.Fill(this.libraryDate1.Binding);

			
		}
		public void populateDGV()
		{
			string selectQuery = "Select * from \"Literature\"";
			table = new DataTable();
		    adapter = new OracleDataAdapter(selectQuery, orc);
			adapter.Fill(table);
			gridBooks.DataSource = table;
		}
		private void gridBooks_MouseClick(object sender, MouseEventArgs e)
		{
			txtID.Text = gridBooks.CurrentRow.Cells[0].Value.ToString();
			txtNameBook.Text = gridBooks.CurrentRow.Cells[1].Value.ToString();
			txtDescription.Text = gridBooks.CurrentRow.Cells[6].Value.ToString();
			txtCountBook.Text = gridBooks.CurrentRow.Cells[4].Value.ToString();
			txtPagesCount.Text = gridBooks.CurrentRow.Cells[5].Value.ToString();
			txtPriceBook.Text = gridBooks.CurrentRow.Cells[3].Value.ToString();
			txtYearBook.Text = gridBooks.CurrentRow.Cells[2].Value.ToString();
			cmbCategory.Text = gridBooks.CurrentRow.Cells[9].Value.ToString();
			cmbPubHouse.Text = gridBooks.CurrentRow.Cells[7].Value.ToString();
			cmbStorage.Text = gridBooks.CurrentRow.Cells[11].Value.ToString();
			cmbView.Text = gridBooks.CurrentRow.Cells[8].Value.ToString();
			cmbBind.Text = gridBooks.CurrentRow.Cells[10].Value.ToString();

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

		private void btnUpdateBook_Click(object sender, EventArgs e)
		{
			
			OracleCommandBuilder orb = new OracleCommandBuilder(adapter);
			adapter.Update(table);
			populateDGV();
		}
		public void executeMyQuery(string query)
{
	try
	{
		openConnection();
		oracmd = new OracleCommand(query,orc);
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
		/*public void cc()
		{
			//cmbPubHouse.Items.Clear();
			orc.Open();
			OracleCommand cmd = orc.CreateCommand();
			cmd.CommandType = CommandType.Text;
			cmd.CommandText = "Select * from \"Public_house\"";
			cmd.ExecuteNonQuery();
			DataTable data = new DataTable();
			OracleDataAdapter adapter = new OracleDataAdapter(cmd);
			adapter.Fill(data);
			foreach (DataRow dr in data.Rows)
			{

				cmbPubHouse.SelectedValue = dr["CHIPER"].ToString();
				cmbPubHouse.Items.Add(dr["Name"].ToString());
			}
			orc.Close();
		}*/
		private void btnDeleteBook_Click(object sender, EventArgs e)
		{
			/*orc.Open();
			oracmd = new OracleCommand("DELETE FROM \"Literature\" where CODE='"+label12.Text+"'", orc);
			oracmd.ExecuteNonQuery();
			orc.Close();
			MessageBox.Show("Удалено!");*/
			if (MessageBox.Show("Вы действительно хотите удалить?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				
				string deleteQuery = "DELETE FROM \"Literature\" where CODE=" + int.Parse(txtID.Text);
				executeMyQuery(deleteQuery);

			}
			populateDGV();
		}

		




		/*private void setConnection()
{
String connectrionString = ConfigurationManager.ConnectionStrings[@"DATA SOURCE = localhost:1521 / XE; PERSIST SECURITY INFO = True; USER ID = SHIN; Password = 123 "].ConnectionString;
orc = new OracleConnection(connectrionString);
try
{
orc.Open();
}
catch(Exception exp) {

}
}*/


	}
}
