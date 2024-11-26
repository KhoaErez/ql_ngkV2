using btl_ngk.Controller;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace btl_ngk
{
	public partial class frmHoaDon : Form
	{
		HoaDon hd = new HoaDon();
		KhachHang kh = new KhachHang();
		NuocGiaiKhat ngk = new NuocGiaiKhat();

		public frmHoaDon()
		{
			InitializeComponent();
			cboMaKH.DataSource = kh.readDL();
			cboMaKH.ValueMember = "MaKH";
			cboMaKH.DisplayMember = "MaKH";

			cboMaNGK.DataSource = ngk.readDL();
			cboMaNGK.ValueMember = "MaNGK";
			cboMaNGK.DisplayMember = "MaNGK";

			cboMaHoaDon.DataSource = hd.readDL();
			cboMaHoaDon.ValueMember = "MaHD";
			cboMaHoaDon.DisplayMember = "MaHD";
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			int soluong;
			int dongia;
			if (int.TryParse(txtSoLuong.Text, out soluong) && int.TryParse(txtDonGia.Text, out dongia))
			{
				hd.themDL(txtMaHD.Text, dtpNgayLapHD.Value, cboMaKH.Text, cboMaNGK.Text, soluong, dongia, txtTenKH.Text, txtDiaChi.Text, txtSDT.Text);
				var tt = soluong * dongia;
				txtThanhTien.Text = tt.ToString();
				dgvHDBanHang.DataSource = hd.readDL();
			}
			else
			{
				MessageBox.Show("Giá trị số lượng hoặc đơn giá không hợp lệ!", "Thông báo");
			}
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtMaHD.Text))
			{
				MessageBox.Show("Vui lòng chọn thông tin cần sửa", "Thông báo");
				return;
			}

			int soluong;
			int dongia;
			if (int.TryParse(txtSoLuong.Text, out soluong) && int.TryParse(txtDonGia.Text, out dongia))
			{
				hd.suaDL(txtMaHD.Text, dtpNgayLapHD.Value, cboMaKH.Text, cboMaNGK.Text, soluong, dongia, txtTenKH.Text, txtDiaChi.Text, txtSDT.Text);
				var tt = soluong * dongia;
				txtThanhTien.Text = tt.ToString();
				dgvHDBanHang.DataSource = hd.readDL();
			}
			else
			{
				MessageBox.Show("Giá trị số lượng hoặc đơn giá không hợp lệ!", "Thông báo");
			}
		}

		private void btnPhieuGhiNo_Click(object sender, EventArgs e)
		{
			Form frmPGN = new frmPhieuNo(txtMaHD.Text,txtThanhTien.Text);
			frmPGN.ShowDialog();
		}

		private void cboMaKH_SelectedIndexChanged(object sender, EventArgs e)
		{
			string ma = cboMaKH.Text;
			string tenkh = $"select tenkh from KhachHang where makh = '{ma}'";
			string diachi = $"select diachi from KhachHang where makh = '{ma}'";
			string sdt = $"select sdt from KhachHang where makh = '{ma}'";
			txtTenKH.Text = hd.readText(tenkh);
			txtDiaChi.Text = hd.readText(diachi);
			txtSDT.Text = hd.readText(sdt);
		}

		private void cboMaNGK_SelectedIndexChanged(object sender, EventArgs e)
		{
			string ma = cboMaNGK.Text;
			string tenngk = $"select tenngk from NuocGiaiKhat where mangk = '{ma}'";
			string dongia = $"select dongia from NuocGiaiKhat where mangk = '{ma}'";
			txtTenNGK.Text = hd.readText(tenngk);
			txtDonGia.Text = hd.readText(dongia);
		}

		private void btnReload_Click(object sender, EventArgs e)
		{
			dgvHDBanHang.DataSource = hd.readDL();

			cboMaHoaDon.DataSource = hd.readDL();
			cboMaHoaDon.ValueMember = "MaHD";
			cboMaHoaDon.DisplayMember = "MaHD";
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtMaHD.Text))
			{
				MessageBox.Show("Vui lòng chọn thông tin cần xóa", "Thông báo");
				return;
			}
			hd.xoaDL(txtMaHD.Text, cboMaNGK.Text);
			MessageBox.Show("Xóa thành công!", "Thông báo");
			dgvHDBanHang.DataSource= hd.readDL();
		}

		private void dgvHDBanHang_MouseClick(object sender, MouseEventArgs e)
		{
			var row = dgvHDBanHang.CurrentRow;
			txtMaHD.Text = row.Cells[0].Value.ToString();
			dtpNgayLapHD.Value = Convert.ToDateTime(row.Cells[1].Value).Date;
			cboMaKH.Text = row.Cells[2].Value.ToString();
			cboMaNGK.Text = row.Cells[3].Value.ToString();
			txtSoLuong.Text = row.Cells[4].Value.ToString();
			txtDonGia.Text = row.Cells[5].Value.ToString();

			var tt = int.Parse(txtDonGia.Text) * int.Parse(txtSoLuong.Text);
			txtThanhTien.Text = tt.ToString();
		}


	}
}
