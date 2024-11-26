using btl_ngk.Controller;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btl_ngk
{
	public partial class frmKhachHang : Form
	{
		KhachHang kh = new KhachHang();

		public frmKhachHang()
		{
			InitializeComponent();
			// Tải dữ liệu khách hàng khi form được khởi tạo
			dgvKhachHang.DataSource = kh.readDL();
		}

		// Tải lại danh sách khách hàng khi nhấn Load
		private void btnLoad_Click(object sender, EventArgs e)
		{
			dgvKhachHang.DataSource = kh.readDL();
		}

		// Đóng form khi nhấn Exit
		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		// Khi click chuột vào dòng của dgvKhachHang, điền thông tin vào các textbox
		private void dgvKhachHang_MouseClick(object sender, MouseEventArgs e)
		{
			var row = dgvKhachHang.CurrentRow;
			if (row != null)  // Kiểm tra nếu dòng được chọn không phải là null
			{
				txtMaKH.Text = row.Cells[0].Value.ToString();
				txtTenKH.Text = row.Cells[1].Value.ToString();
				txtDiaChi.Text = row.Cells[2].Value.ToString();
				txtDienThoai.Text = row.Cells[3].Value.ToString();
			}
		}

		// Thêm khách hàng
		private void btnThem_Click(object sender, EventArgs e)
		{
			// Kiểm tra thông tin đã nhập đầy đủ chưa
			if (string.IsNullOrEmpty(txtMaKH.Text) || string.IsNullOrEmpty(txtTenKH.Text) || string.IsNullOrEmpty(txtDiaChi.Text) || string.IsNullOrEmpty(txtDienThoai.Text))
			{
				MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo");
				return;
			}

			// Kiểm tra xem mã khách hàng đã tồn tại chưa
			if (kh.checkMa(txtMaKH.Text))
			{
				MessageBox.Show("Mã khách hàng đã tồn tại. Vui lòng chọn mã khác.", "Thông báo");
				return;
			}

			// Thêm khách hàng
			kh.themDL(txtMaKH.Text, txtTenKH.Text, txtDiaChi.Text, txtDienThoai.Text);

			// Tải lại danh sách khách hàng
			dgvKhachHang.DataSource = kh.readDL();
		}

		// Sửa thông tin khách hàng
		private void btnSua_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtMaKH.Text))
			{
				MessageBox.Show("Vui lòng chọn khách hàng cần sửa", "Thông báo");
				return;
			}

			// Sửa thông tin khách hàng
			kh.suaDL(txtMaKH.Text, txtTenKH.Text, txtDiaChi.Text, txtDienThoai.Text);

			// Tải lại danh sách khách hàng
			dgvKhachHang.DataSource = kh.readDL();
		}

		//xóa khách hàng
		private void btnXoa_Click_1(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtMaKH.Text))
			{
				MessageBox.Show("Vui lòng chọn khách hàng cần xóa", "Thông báo");
				return;
			}

			// Xóa khách hàng
			kh.xoaDL(txtMaKH.Text);

			// Tải lại danh sách khách hàng
			dgvKhachHang.DataSource = kh.readDL();
		}
	}
}
