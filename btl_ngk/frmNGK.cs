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
	public partial class frmNGK : Form
	{
		NuocGiaiKhat ngk = new NuocGiaiKhat();
		LoaiNuocGK loaiNGK = new LoaiNuocGK();

		public frmNGK()
		{
			InitializeComponent();
			// Load dữ liệu cho dgvNGK từ lớp NuocGiaiKhat
			dgvNGK.DataSource = ngk.readDL();

			// Load dữ liệu cho cboMaLoaiNGK từ lớp LoaiNuocGK
			cboMaLoaiNGK.DataSource = loaiNGK.readDL();
			cboMaLoaiNGK.ValueMember = "MaLoai";
			cboMaLoaiNGK.DisplayMember = "TenLoai";  // Hiển thị tên loại nước giải khát
		}

		private void dgvNGK_MouseClick(object sender, MouseEventArgs e)
		{
			// Khi người dùng click vào một dòng trong DataGridView
			var row = dgvNGK.CurrentRow;
			txtMaNGK.Text = row.Cells[0].Value.ToString();  // Mã nước giải khát
			txtTenNGK.Text = row.Cells[1].Value.ToString();  // Tên nước giải khát
			cboMaLoaiNGK.SelectedValue = row.Cells[2].Value.ToString();  // Mã loại nước giải khát
			txtDonGia.Text = row.Cells[3].Value.ToString();  // đơn giá nước giải khát
		}

		private void btnLoad_Click(object sender, EventArgs e)
		{
			// Nút Load lại dữ liệu cho DataGridView
			dgvNGK.DataSource = ngk.readDL();
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			// Thêm một nước giải khát mới
			if (string.IsNullOrEmpty(txtMaNGK.Text) || string.IsNullOrEmpty(txtTenNGK.Text) || cboMaLoaiNGK.SelectedIndex == -1)
			{
				MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
				return;
			}
			int dongia;
			if (int.TryParse(txtDonGia.Text, out dongia))
			{
				ngk.themDL(txtMaNGK.Text, txtTenNGK.Text, cboMaLoaiNGK.SelectedValue.ToString(), dongia);
				dgvNGK.DataSource = ngk.readDL();  // Cập nhật lại DataGridView sau khi thêm
				dgvNGK.DataSource = ngk.readDL();  // Cập nhật lại DataGridView sau khi sửa
			}
			else
			{
				MessageBox.Show("Giá trị đơn giá không hợp lệ", "Thông báo");
			}
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			// Xóa nước giải khát dựa trên mã nước giải khát
			if (string.IsNullOrEmpty(txtMaNGK.Text))
			{
				MessageBox.Show("Vui lòng chọn thông tin cần xóa!");
				return;
			}
			ngk.xoaDL(txtMaNGK.Text);
			dgvNGK.DataSource = ngk.readDL();  // Cập nhật lại DataGridView sau khi xóa
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			// Sửa thông tin nước giải khát
			if (string.IsNullOrEmpty(txtMaNGK.Text))
			{
				MessageBox.Show("Vui lòng chọn thông tin cần sửa!");
				return;
			}
			int dongia;
			if(int.TryParse(txtDonGia.Text, out dongia))
			{
				ngk.suaDL(txtMaNGK.Text, txtTenNGK.Text, cboMaLoaiNGK.SelectedValue.ToString(), dongia);
				dgvNGK.DataSource = ngk.readDL();  // Cập nhật lại DataGridView sau khi sửa
			}
			else
			{
				MessageBox.Show("Giá trị đơn giá không hợp lệ","Thông báo");
			}
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			// Đóng form khi nhấn nút Exit
			this.Close();
		}
	}
}
