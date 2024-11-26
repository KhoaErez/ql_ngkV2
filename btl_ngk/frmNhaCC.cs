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
	public partial class frmNhaCC : Form
	{
		NhaCungCap ncc = new NhaCungCap();

		public frmNhaCC()
		{
			InitializeComponent();
			dgvNhaCC.DataSource = ncc.readDL();
		}

		private void btnReload_Click(object sender, EventArgs e)
		{
			dgvNhaCC.DataSource = ncc.readDL();
			txtMaNhaCC.Text = "";
			txtTenNhaCC.Text = "";
			txtDiaChi.Text = "";
			txtDT.Text = "";
			txtMaNhaCC.Enabled = true;
		}

		private void dgvNhaCC_MouseClick(object sender, MouseEventArgs e)
		{
			var row = dgvNhaCC.CurrentRow;
			txtMaNhaCC.Text = row.Cells[0].Value.ToString();
			txtTenNhaCC.Text = row.Cells[1].Value.ToString();
			txtDiaChi.Text = row.Cells[2].Value.ToString();
			txtDT.Text = row.Cells[3].Value.ToString();
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtMaNhaCC.Text) || string.IsNullOrEmpty(txtTenNhaCC.Text) || string.IsNullOrEmpty(txtDiaChi.Text) || string.IsNullOrEmpty(txtDT.Text))
			{
				MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo");
				return;
			}
			ncc.themDL(txtMaNhaCC.Text, txtTenNhaCC.Text, txtDiaChi.Text, txtDT.Text);
			dgvNhaCC.DataSource = ncc.readDL();
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtMaNhaCC.Text))
			{
				MessageBox.Show("Vui lòng chọn thông tin cần xóa!", "Thông báo");
				return;
			}
			ncc.xoaDL(txtMaNhaCC.Text);
			dgvNhaCC.DataSource = ncc.readDL();
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtMaNhaCC.Text))
			{
				MessageBox.Show("Vui lòng chọn thông tin cần sửa", "Thông báo");
				return;
			}
			ncc.suaDL(txtMaNhaCC.Text, txtTenNhaCC.Text, txtDiaChi.Text, txtDT.Text);
			dgvNhaCC.DataSource = ncc.readDL();
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
