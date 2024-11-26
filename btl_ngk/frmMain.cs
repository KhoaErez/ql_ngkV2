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
	public partial class frmMain : Form
	{
		public frmMain()
		{
			InitializeComponent();
		}

		private void đơnĐặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form frmQlDDH = new frmQLDonDH();
			frmQlDDH.ShowDialog();
		}

		private void mnuDonDH_Click(object sender, EventArgs e)
		{
			Form frmDonDH = new frmLapDDH();
			frmDonDH.ShowDialog();
		}

		private void mnuPhieuGH_Click(object sender, EventArgs e)
		{
			Form frmPGH = new frmPGH();
			frmPGH.ShowDialog();
		}

		private void mnuHoaDon_Click(object sender, EventArgs e)
		{
			Form frmHD = new frmHoaDon();
			frmHD.ShowDialog();
		}

		private void mnuNhaCC_Click(object sender, EventArgs e)
		{
			Form frmNcc = new frmNhaCC();
			frmNcc.ShowDialog();
		}

		private void mnuLoaiNGK_Click(object sender, EventArgs e)
		{
			Form frmLoaiNgk = new frmLoaiNGK();
			frmLoaiNgk.ShowDialog();
		}

		private void mnuNGK_Click(object sender, EventArgs e)
		{
			Form frmNgk = new frmNGK();
			frmNgk.ShowDialog();
		}

		private void mnuNhanVien_Click(object sender, EventArgs e)
		{

		}

		private void mnuKhachHang_Click(object sender, EventArgs e)
		{
			Form frmKH = new frmKhachHang();
			frmKH.ShowDialog();
		}

		private void mnuPhieuHen_Click(object sender, EventArgs e)
		{
			Form frmPH = new frmPhieuHen();
			frmPH.ShowDialog();
		}

		private void mnuPhieuNo_Click(object sender, EventArgs e)
		{
			Form frmPN = new frmPhieuNo();
			frmPN.ShowDialog();
		}

		private void mnuMatHangBanChay_Click(object sender, EventArgs e)
		{
			Form frmBC = new frmThongKeNGK_BanChay();
			frmBC.ShowDialog();
		}

		private void mnuThongKeDoanhSo_Click(object sender, EventArgs e)
		{
			Form frmDS = new frmThongKe_DoanhSo();
			frmDS.ShowDialog();
		}

		private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string username = frmDangNhap.GetCurrentUsername();  // Phương thức giả định trả về tên tài khoản người dùng

			// Kiểm tra nếu tài khoản là "khoa"
			if (username == "khoa")
			{
				Form frmNV = new frmNhanVien();
				frmNV.ShowDialog();
			}
			else
			{
				MessageBox.Show("Bạn không có quyền truy cập vào trang nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
	}
}
