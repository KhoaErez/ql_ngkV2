using btl_ngk.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btl_ngk
{
	public partial class frmPGH : Form
	{
		PhieuGiaoHang pgh = new PhieuGiaoHang();
		DonDatHang ddh = new DonDatHang();
		NuocGiaiKhat ngk = new NuocGiaiKhat();

		public frmPGH()
		{
			InitializeComponent();
			// Load dữ liệu ban đầu vào DataGridView
			dgvPhieuGH.DataSource = pgh.readDL();

			// Cập nhật combobox Mã đơn đặt hàng
			cboMaDDH.DataSource = ddh.readMa();
			cboMaDDH.ValueMember = "MaDDH";
			cboMaDDH.DisplayMember = "MaDDH";

			// Cập nhật combobox Mã nước giải khát
			cboMaNGK.DataSource = ngk.readDL();
			cboMaNGK.ValueMember = "MaNGK";
			cboMaNGK.DisplayMember = "MaNGK";
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			int soluong;
			int dongia;

			// Kiểm tra tính hợp lệ của Số lượng và Đơn giá
			if (int.TryParse(txtSoLuong.Text, out soluong) && int.TryParse(txtDonGia.Text, out dongia))
			{
				// Thêm dữ liệu vào cơ sở dữ liệu
				pgh.themDL(txtMaPhieuGH.Text, cboMaDDH.Text, dtpNgayGiao.Value, cboMaNGK.Text, soluong, dongia);
				
				// Cập nhật lại DataGridView
				dgvPhieuGH.DataSource = pgh.readDL();
			}
			else
			{
				MessageBox.Show("Số lượng hoặc đơn giá không hợp lệ", "Thông báo");
			}
		}

		private void dgvPhieuGH_MouseClick(object sender, MouseEventArgs e)
		{
			var row = dgvPhieuGH.CurrentRow;
			if (row != null)
			{
				txtMaPhieuGH.Text = row.Cells[0].Value.ToString();
				cboMaDDH.Text = row.Cells[1].Value.ToString();
				dtpNgayGiao.Value = Convert.ToDateTime(row.Cells[2].Value).Date;
				cboMaNGK.Text = row.Cells[3].Value.ToString();
				txtSoLuong.Text = row.Cells[4].Value.ToString();
				txtDonGia.Text = row.Cells[5].Value.ToString();
			}
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtMaPhieuGH.Text))
			{
				MessageBox.Show("Vui lòng chọn thông tin cần sửa!", "Thông báo");
				return;
			}

			int soluong;
			int dongia;

			// Kiểm tra tính hợp lệ của Số lượng và Đơn giá
			if (int.TryParse(txtSoLuong.Text, out soluong) && int.TryParse(txtDonGia.Text, out dongia))
			{
				// Sửa thông tin trong cơ sở dữ liệu
				pgh.suaDL(txtMaPhieuGH.Text, cboMaDDH.Text, dtpNgayGiao.Value, cboMaNGK.Text, soluong, dongia);
				
				// Cập nhật lại DataGridView
				dgvPhieuGH.DataSource = pgh.readDL();
			}
			else
			{
				MessageBox.Show("Số lượng hoặc đơn giá không hợp lệ", "Thông báo");
			}
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtMaPhieuGH.Text))
			{
				MessageBox.Show("Vui lòng chọn thông tin cần xóa!", "Thông báo");
				return;
			}

			// Xóa thông tin khỏi cơ sở dữ liệu
			pgh.xoaDL(txtMaPhieuGH.Text, cboMaNGK.Text);
			
			// Cập nhật lại DataGridView
			dgvPhieuGH.DataSource = pgh.readDL();
		}

		private void btnTimKiem_Click(object sender, EventArgs e)
		{
			// Tìm kiếm theo Mã Phiếu Giao Hàng
			dgvPhieuGH.DataSource = pgh.timKiem(txtTimMaPGH.Text);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			// Làm mới DataGridView để hiển thị lại tất cả dữ liệu
			dgvPhieuGH.DataSource = pgh.readDL();
		}

		private void cboMaDDH_SelectedIndexChanged(object sender, EventArgs e)
		{
			string maddh = cboMaDDH.SelectedValue.ToString();
			if(maddh.Length > 0)
			{
				string sql = $"select SoLuongDat from ChiTietDonDatHang where MaDDH = '{maddh}'";
				var soluong = pgh.kn.readText(sql);
				txtSoLuong.Text = soluong;
			} 
				
		}
	}
}
