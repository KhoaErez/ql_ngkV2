using btl_ngk.Controller;
using System;
using System.Windows.Forms;

namespace btl_ngk
{
	public partial class frmPhieuNo : Form
	{
		PhieuNo pn = new PhieuNo();
		HoaDon hd = new HoaDon();

		public frmPhieuNo()
		{
			InitializeComponent();
			dgvPhieuTraNo.DataSource = pn.readDL();
			cboMaHD.DataSource = hd.readDL();
			cboMaHD.ValueMember = "MaHD";
			cboMaHD.DisplayMember = "MaHD";
		}

		public frmPhieuNo(string ma, string thanhtien)
		{
			InitializeComponent();
			cboMaHD.Text = ma;
			txtSoTienTra.Text = thanhtien;

			cboMaHD.DataSource = hd.readDL();
			cboMaHD.ValueMember = "MaHD";
			cboMaHD.DisplayMember = "MaHD";
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			int soTienTra;
			if (int.TryParse(txtSoTienTra.Text, out soTienTra))
			{
				pn.themDL(txtMaPhieuTN.Text,dtpNgayTra.Value, soTienTra, cboMaHD.Text);
				dgvPhieuTraNo.DataSource = pn.readDL();  // Cập nhật lại dữ liệu
			}
			else
			{
				MessageBox.Show("Kiểu dữ liệu số tiền trả không hợp lệ", "Thông báo");
			}
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtMaPhieuTN.Text))
			{
				MessageBox.Show("Vui lòng điền thông tin cần sửa!", "Thông báo");
				return;
			}
			int soTienTra;
			if (int.TryParse(txtSoTienTra.Text, out soTienTra))
			{
				pn.suaDL(txtMaPhieuTN.Text, dtpNgayTra.Value, soTienTra, cboMaHD.Text);
				dgvPhieuTraNo.DataSource = pn.readDL();  // Cập nhật lại dữ liệu sau khi sửa
			}
			else
			{
				MessageBox.Show("Kiểu dữ liệu số tiền trả không hợp lệ", "Thông báo");
			}
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtMaPhieuTN.Text))
			{
				MessageBox.Show("Vui lòng điền thông tin cần xóa!", "Thông báo");
				return;
			}
			pn.xoaDL(txtMaPhieuTN.Text);
			dgvPhieuTraNo.DataSource = pn.readDL();  // Cập nhật lại dữ liệu sau khi xóa
		}

		private void button1_Click(object sender, EventArgs e)
		{
			dgvPhieuTraNo.DataSource = pn.readDL();  // Làm mới dữ liệu
			txtMaPhieuTN.Text = "";
			cboMaHD.Text = "";
			txtSoTienTra.Text = "";
			txtTimKiem.Text = "";
		}

		private void btnTimKiem_Click(object sender, EventArgs e)
		{
			dgvPhieuTraNo.DataSource = pn.timDL(txtTimKiem.Text);  // Tìm kiếm và cập nhật
		}

		private void dgvPhieuTraNo_MouseClick(object sender, MouseEventArgs e)
		{
			var row = dgvPhieuTraNo.CurrentRow;
			txtMaPhieuTN.Text = row.Cells[0].Value.ToString();
			dtpNgayTra.Value = Convert.ToDateTime(row.Cells[1].Value).Date;
			txtSoTienTra.Text = row.Cells[2].Value.ToString();
			cboMaHD.Text = row.Cells[3].Value.ToString();
		}
	}
}
