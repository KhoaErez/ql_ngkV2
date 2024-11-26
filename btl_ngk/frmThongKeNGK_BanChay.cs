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
	public partial class frmThongKeNGK_BanChay : Form
	{
		ThongKe tk = new ThongKe();
		public frmThongKeNGK_BanChay()
		{
			InitializeComponent();
			dgvTkeBanChay.DataSource = tk.thongKeBanChay();
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}

        private void dgvTkeBanChay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
