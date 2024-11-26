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
	public partial class frmLoaiNGK : Form
	{
		LoaiNuocGK loaiNuocGK = new LoaiNuocGK();
		NhaCungCap ncc = new NhaCungCap();

		public frmLoaiNGK()
		{
			InitializeComponent();
			dgvLoaiNGK.DataSource = loaiNuocGK.readDL();

			cboMaNhaCC.DataSource = ncc.readDL();
			cboMaNhaCC.ValueMember = "MaNCC";
			cboMaNhaCC.DisplayMember = "TenNCC";  
		}

		private void dgvLoaiNGK_MouseClick(object sender, MouseEventArgs e)
		{
			var row = dgvLoaiNGK.CurrentRow;
			txtMaLoaiNGK.Text = row.Cells[0].Value.ToString();
			txtTenLoaiNGK.Text = row.Cells[1].Value.ToString();
			cboMaNhaCC.SelectedValue = row.Cells[2].Value.ToString(); 
		}

		private void btnLoad_Click(object sender, EventArgs e)
		{
			dgvLoaiNGK.DataSource = loaiNuocGK.readDL();
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtMaLoaiNGK.Text) || string.IsNullOrEmpty(txtTenLoaiNGK.Text) || cboMaNhaCC.SelectedItem == null)
			{
				MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo");
				return;
			}
			loaiNuocGK.themDL(txtMaLoaiNGK.Text, txtTenLoaiNGK.Text, cboMaNhaCC.SelectedValue.ToString());
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtMaLoaiNGK.Text))
			{
				MessageBox.Show("Vui lòng chọn thông tin cần xóa!", "Thông báo");
				return;
			}
			loaiNuocGK.xoaDL(txtMaLoaiNGK.Text);
			dgvLoaiNGK.DataSource = loaiNuocGK.readDL();
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtMaLoaiNGK.Text))
			{
				MessageBox.Show("Vui lòng chọn thông tin cần sửa!", "Thông báo");
				return;
			}
			loaiNuocGK.suaDL(txtMaLoaiNGK.Text, txtTenLoaiNGK.Text, cboMaNhaCC.SelectedValue.ToString());
			dgvLoaiNGK.DataSource = loaiNuocGK.readDL();
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
