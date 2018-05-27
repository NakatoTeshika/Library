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

namespace Library
{
	public partial class Extradition : Form
	{
		OracleConnection orc = new OracleConnection(@"DATA SOURCE=localhost:1521/XE;PERSIST SECURITY INFO=True;USER ID=SHIN; Password = 123 ");
		private const String STOREDPROCEDURENAME = "SHIN.EXTRADITION_INSERT";
		private const String EXTRADITION_ID= "EXTRADITION_ID";
		private const String FIELD1_PARM = "RESERVATION_ID";
		private const String FIELD2_PARM = "READER_ID";
		private const String FIELD3_PARM = "CODE";
		private const String FIELD4_PARM = "STORAGE_ID";
		private const String FIELD5_PARM = "ISSUE_TIME";
		private const String FIELD6_PARM = "LIBRARIAN_ID";
		OracleCommand oracmd;
		OracleDataAdapter adapter;
		DataTable table;
		public Extradition()
		{
			InitializeComponent();
		}

		private void Extradition_Load(object sender, EventArgs e)
		{
			cc();
		}
		public void cc()
		{
			cmbReservation.Items.Clear();
			orc.Open();
			OracleCommand cmd = orc.CreateCommand();
			cmd.CommandType = CommandType.Text;
			cmd.CommandText = "Select * from \"Reservation\"";
			cmd.ExecuteNonQuery();
			DataTable data = new DataTable();
			OracleDataAdapter adapter = new OracleDataAdapter(cmd);
			adapter.Fill(data);
			foreach (DataRow dr in data.Rows)
			{
				cmbReservation.Items.Add(dr["Reservation_ID"].ToString());
			}
			orc.Close();
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
		private void cmbReservation_SelectedIndexChanged(object sender, EventArgs e)
		{
			orc.Open();
			OracleCommand cmd = orc.CreateCommand();
			cmd.CommandType = CommandType.Text;
			cmd.CommandText = "Select * from \"Reservation\" where Reservation_ID = '" + cmbReservation.SelectedItem.ToString()+"'";
			cmd.ExecuteNonQuery();
		
			DataTable data = new DataTable();
			OracleDataAdapter adapter = new OracleDataAdapter(cmd);
			adapter.Fill(data);
			foreach (DataRow dr in data.Rows)
			{
				txtReader.Text = dr["Reader_ID"].ToString();
				txtCode.Text = dr["Code"].ToString();
				//txtLibrarian.Text = dr["Librarian_ID"].ToString();
				txtStorage.Text = dr["Storage_ID"].ToString();
			}
			
			//cmd.CommandText = "Select Name from \"Reader\" where Reader_ID ";
			//textBox1.Text = "Select Name from \"Reader\" where Reader_ID = '" + int.Parse(txtReader.Text) + "'";
			orc.Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			OracleCommand orcmd = new OracleCommand();
			orcmd.Connection = orc;
			orcmd.CommandText = STOREDPROCEDURENAME;
			orcmd.CommandType = CommandType.StoredProcedure;
			// Add the parameters and set values for them.
			orcmd.Parameters.Add(EXTRADITION_ID, OracleDbType.Int32).Direction =
				  ParameterDirection.Output;
			orcmd.Parameters.Add(FIELD1_PARM, OracleDbType.Int32);
			orcmd.Parameters.Add(FIELD2_PARM, OracleDbType.Int32);
			orcmd.Parameters.Add(FIELD3_PARM, OracleDbType.Int32);
			orcmd.Parameters.Add(FIELD4_PARM, OracleDbType.Int32);
			orcmd.Parameters.Add(FIELD5_PARM, OracleDbType.Date);
			orcmd.Parameters.Add(FIELD6_PARM, OracleDbType.Int32);
	
			orcmd.Parameters[FIELD1_PARM].Value = cmbReservation.Text;
			orcmd.Parameters[FIELD2_PARM].Value = txtReader.Text;
			orcmd.Parameters[FIELD3_PARM].Value = txtCode.Text;
			orcmd.Parameters[FIELD4_PARM].Value = txtStorage.Text;
			orcmd.Parameters[FIELD5_PARM].Value = dateTimePicker.Value;
			orcmd.Parameters[FIELD6_PARM].Value = txtLibrarian.Text;

			string update = "UPDATE \"Literature\" SET NUMBER_OF_COPIES = NUMBER_OF_COPIES - 1 WHERE CODE = " + int.Parse(txtCode.Text);
			executeMyQuery(update);
			string Extradition_update = "UPDATE \"Extradition_Back_Count\" SET EXTRADITION = EXTRADITION + 1";
			executeMyQuery(Extradition_update);
			// Execute the insert query.
			orc.Open();
			try
			{
				orcmd.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Retrieving Oracle Sequence Values",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			finally
			{
				orc.Close();
			}
		}

	
	}
}
