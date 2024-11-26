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
	public partial class frmPhieuHen : Form
	{
		PhieuHen ph = new PhieuHen();
		KhachHang kh = new KhachHang();
		NuocGiaiKhat ngk = new NuocGiaiKhat();

		public frmPhieuHen()
		{
			InitializeComponent();
			LoadData();
		}

		// Load dữ liệu ban đầu cho các combobox và datagrid
		private void LoadData()
		{
			dgvPhieuHen.DataSource = ph.readDL();

			// Đảm bảo dữ liệu trong các combobox
			cboMaKH.DataSource = kh.readDL();
			cboMaKH.ValueMember = "MaKH";
			cboMaKH.DisplayMember = "MaKH";

			cboMaNGK.DataSource = ngk.readDL();
			cboMaNGK.ValueMember = "MaNGK";
			cboMaNGK.DisplayMember = "MaNGK";
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			int soluong;
			if (int.TryParse(txtSoLuong.Text, out soluong))
			{
				ph.themDL(txtMaPH.Text,cboMaKH.Text, dtpNgayLap.Value, dtpNgayHen.Value, cboMaNGK.Text, soluong);
				LoadData();
			}
			else
			{
				MessageBox.Show("Kiểu dữ liệu số lượng không hợp lệ!", "Thông báo");
			}
		}

		private void btnTim_Click(object sender, EventArgs e)
		{
			dgvPhieuHen.DataSource = ph.timTheoMa(txtMaPhieuHen.Text);
		}

		private void dgvPhieuHen_MouseClick(object sender, MouseEventArgs e)
		{
			var row = dgvPhieuHen.CurrentRow;
			txtMaPH.Text = row.Cells[0].Value.ToString();
			cboMaKH.Text = row.Cells[1].Value.ToString();
			dtpNgayLap.Value = Convert.ToDateTime(row.Cells[2].Value).Date;
			dtpNgayHen.Value = Convert.ToDateTime(row.Cells[3].Value).Date;
			cboMaNGK.Text = row.Cells[4].Value.ToString();
			txtSoLuong.Text = row.Cells[5].Value.ToString();
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtMaPH.Text))
			{
				MessageBox.Show("Vui lòng chọn thông tin cần xóa", "Thông báo");
				return;
			}
			ph.xoaDL(txtMaPH.Text, cboMaNGK.Text);
			LoadData();
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtMaPH.Text))
			{
				MessageBox.Show("Vui lòng chọn thông tin cần sửa", "Thông báo");
				return;
			}
			int soluong;
			if (int.TryParse(txtSoLuong.Text, out soluong))
			{
				ph.suaDL(txtMaPH.Text, cboMaKH.Text, dtpNgayLap.Value, dtpNgayHen.Value, cboMaNGK.Text, soluong);
				LoadData();
			}
			else
			{
				MessageBox.Show("Giá trị số lượng không hợp lệ!", "Thông báo");
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			LoadData();
		}
	}
}
