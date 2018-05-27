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
	public partial class ListOfPublicHouse : Form
	{
		public ListOfPublicHouse()
		{
			InitializeComponent();
		}

		private void ListOfPublicHouse_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "libraryDate.Public_house". При необходимости она может быть перемещена или удалена.
			this.public_houseTableAdapter.Fill(this.libraryDate.Public_house);

		}
	}
}
