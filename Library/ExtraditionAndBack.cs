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
using CrystalDecisions.CrystalReports.Engine;

namespace Library
{

	public partial class ExtraditionAndBack : Form
	{

		OracleConnection orc = new OracleConnection(@"DATA SOURCE=localhost:1521/XE;PERSIST SECURITY INFO=True;USER ID=SHIN; Password = 123 ");
		OracleCommand oracmd;
		OracleDataAdapter adapter;
		DataTable table;
		public ExtraditionAndBack()
		{
			InitializeComponent();
		}
		
		

		private void button1_Click_1(object sender, EventArgs e)
		{
			OracleConnection orc = new OracleConnection(@"DATA SOURCE=localhost:1521/XE;PERSIST SECURITY INFO=True;USER ID=SHIN; Password = 123 ");
			orc.Open();
			string query = "Select * from \"Extradition_Back_Count\"";
			OracleDataAdapter da = new OracleDataAdapter(query, orc);
			DataSet ds = new DataSet();
			da.Fill(ds, "Extradition_Back_Count");
			ReportDocument rDoc = new ReportDocument();
			rDoc.Load("CrystalReport2.rpt");
			rDoc.SetDataSource(ds);
			crystalReportViewer1.ReportSource = rDoc;
		}
	}
}
