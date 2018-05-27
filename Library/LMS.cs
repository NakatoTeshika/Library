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
	public partial class LMS : Form
	{
		public LMS()
		{
			InitializeComponent();
		}

		private void LMS_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

		private void roleToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Books books = new Books();
			books.MdiParent = this;
			books.StartPosition = FormStartPosition.CenterScreen;
			books.Show();
		}

	

		private void publicHouseToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ListOfPublicHouse pb = new ListOfPublicHouse();
			pb.MdiParent = this;
			pb.Show();
		}

		private void authorsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AuthorsList al = new AuthorsList();
			al.MdiParent = this;
			al.Show();

		}

		private void searchToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//this.Hide();
			Search search = new Search();
			search.MdiParent = this;
			search.StartPosition = FormStartPosition.CenterScreen;
			search.Show();
		}

		private void bookInRegisterToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Extradition ex = new Extradition();
			ex.MdiParent = this;
			ex.StartPosition = FormStartPosition.CenterScreen;
			ex.Show();
		}

		private void bookOutRegisterToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Back b = new Back();
			b.MdiParent = this;
			b.StartPosition = FormStartPosition.CenterScreen;
			b.Show();
		}

		private void оПриложенииToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AboutApp about = new AboutApp();
			about.MdiParent = this;
			about.StartPosition = FormStartPosition.CenterScreen;
			about.Show();
		}

		private void отчетТекущегоСеансаToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ExtraditionAndBack back = new ExtraditionAndBack();
			back.MdiParent = this;
			back.StartPosition = FormStartPosition.CenterScreen;
			back.Show();
		}

		private void отчетCrystalReportToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AboutVisit bac = new AboutVisit();
			bac.MdiParent = this;
			bac.StartPosition = FormStartPosition.CenterScreen;
			bac.Show();
		}
	}
}
