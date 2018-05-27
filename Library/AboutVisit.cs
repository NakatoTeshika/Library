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
using CrystalDecisions.CrystalReports;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
namespace Library
{
	public partial class AboutVisit : Form
	{
		public AboutVisit()
		{
			InitializeComponent();
		}
	

		private void button1_Click(object sender, EventArgs e)
		{
			OracleConnection orc = new OracleConnection(@"DATA SOURCE=localhost:1521/XE;PERSIST SECURITY INFO=True;USER ID=SHIN; Password = 123 ");
			orc.Open();
			string query = "Select * from \"Author\"";
			OracleDataAdapter da = new OracleDataAdapter(query,orc);
			DataSet ds = new DataSet();
			da.Fill(ds, "Author");
			ReportDocument rDoc = new ReportDocument();
			rDoc.Load("CrystalReport1.rpt");
			rDoc.SetDataSource(ds);
			crystalReportViewer1.ReportSource = rDoc;
		}
	}
}
