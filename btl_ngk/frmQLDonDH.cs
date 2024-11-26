using btl_ngk.Controller;
using btl_ngk.Model;
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
	public partial class frmQLDonDH : Form
	{
		KetNoi kn = new KetNoi();
		DonDatHang ddh = new DonDatHang();

		public frmQLDonDH()
		{
			InitializeComponent();
			dgvDonDH.DataSource = ddh.readDL(); // Hiển thị dữ liệu đơn đặt hàng ban đầu
		}

		// Hàm này để nạp lại dữ liệu vào DataGridView sau khi gửi đơn
		private void btnGuiDon_Click(object sender, EventArgs e)
		{
			dgvDonDH.DataSource = ddh.readDL(); // Cập nhật lại DataGridView
		}

		// Hàm xử lý xóa đơn hàng
		private void btnXoa_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtMaDDH.Text))
			{
				MessageBox.Show("Vui lòng chọn thông tin cần xóa", "Thông báo");
				return;
			}

			// Thực hiện xóa đơn hàng bằng mã đơn hàng và mã nước giải khát
			ddh.xoaDL(txtMaDDH.Text, txtMaNGK.Text);
			MessageBox.Show("Xóa thành công!", "Thông báo");
			dgvDonDH.DataSource = ddh.readDL(); // Cập nhật lại DataGridView
		}

		// Hàm xử lý sửa đơn hàng
		private void btnSua_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtMaDDH.Text))
			{
				MessageBox.Show("Vui lòng chọn thông tin cần sửa", "Thông báo");
				return;
			}

			int soluong;
			if (int.TryParse(txtSoLuong.Text, out soluong))
			{
				// Thực hiện cập nhật đơn hàng
				ddh.suaDL(txtMaDDH.Text, dtpNgayDH.Value, txtMaNCC.Text, txtMaNGK.Text, soluong);
				MessageBox.Show("Sửa thành công!", "Thông báo");
				dgvDonDH.DataSource = ddh.readDL(); // Cập nhật lại DataGridView
			}
			else
			{
				MessageBox.Show("Số lượng không đúng kiểu dữ liệu", "Thông báo");
			}
		}

		// Lưu tên NCC và NGK khi click vào dòng trong DataGridView
		string tenNCC;
		string tenNGK;
		private void dgvDonDH_MouseClick(object sender, MouseEventArgs e)
		{
			// Lấy các giá trị từ DataGridView
			txtMaDDH.Text = dgvDonDH.CurrentRow.Cells[0].Value.ToString();
			dtpNgayDH.Text = dgvDonDH.CurrentRow.Cells[1].Value.ToString();
			tenNCC = dgvDonDH.CurrentRow.Cells[2].Value.ToString();
			tenNGK = dgvDonDH.CurrentRow.Cells[3].Value.ToString();
			txtSoLuong.Text = dgvDonDH.CurrentRow.Cells[4].Value.ToString();

			// Truy vấn mã NCC và NGK từ cơ sở dữ liệu bằng tên NCC và NGK
			string selectMaNCC = $"select mancc from NhaCungCap where TenNCC = N'{tenNCC}'";
			string selectMaNGK = $"select mangk from NuocGiaiKhat where tenngk = N'{tenNGK}'";

			// Đọc dữ liệu từ cơ sở dữ liệu và cập nhật vào các TextBox
			txtMaNCC.Text = kn.readText(selectMaNCC);
			txtMaNGK.Text = kn.readText(selectMaNGK);
		}

		// Hàm thoát khỏi form
		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
