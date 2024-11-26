using btl_ngk.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btl_ngk
{
	public partial class frmNhanVien : Form
	{
		NhanVien nv = new NhanVien();
		public frmNhanVien()
		{
			InitializeComponent();
			dataGridView1.DataSource = nv.readDL();
		}

		private void button1_Click(object sender, EventArgs e)
		{

		}

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
