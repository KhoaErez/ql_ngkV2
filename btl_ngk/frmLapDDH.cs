using btl_ngk.Controller;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btl_ngk
{
	public partial class frmLapDDH : Form
	{
		DonDatHang ddh = new DonDatHang();
		NhaCungCap ncc = new NhaCungCap();
		NuocGiaiKhat ngk = new NuocGiaiKhat();

		public frmLapDDH()
		{
			InitializeComponent();
			cboMaNCC.DataSource = ncc.readDL();
			cboMaNCC.ValueMember = "MaNCC";  
			cboMaNCC.DisplayMember = "MaNCC";  

			cboMaNGK.DataSource = ngk.readDL();
			cboMaNGK.ValueMember = "MaNGK";  
			cboMaNGK.DisplayMember = "MaNGK"; 
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnGuiDon_Click(object sender, EventArgs e)
		{
			int soluong;
			if (!int.TryParse(txtSoLuong.Text, out soluong))
			{
				MessageBox.Show("Giá trị số lượng không hợp lệ!", "Thông báo");
			}
			else
			{
				ddh.themDL(txtMaDDH.Text, dtpNgayDH.Value, cboMaNCC.SelectedValue.ToString(), cboMaNGK.SelectedValue.ToString(), soluong);
				richTextBox1.Text = "Mã đơn đặt hàng: " + txtMaDDH.Text + "\n" +
									"Ngày đặt hàng: " + dtpNgayDH.Text + "\n" +
									"Nhà cung cấp: " + txtTenNCC.Text + "\n" +
									"Nước giải khát: " + txtTenNGK.Text + "\n" +
									"Số lượng: " + txtSoLuong.Text + "\n";
			}
		}

		private void cboMaNCC_SelectedIndexChanged(object sender, EventArgs e)
		{
			var selectedItem = (DataRowView)cboMaNCC.SelectedItem;
			txtTenNCC.Text = selectedItem["TenNCC"].ToString();
		}

		private void cboMaNGK_SelectedIndexChanged(object sender, EventArgs e)
		{
			var selectedItem = (DataRowView)cboMaNGK.SelectedItem;
			txtTenNGK.Text = selectedItem["TenNGK"].ToString();
		}
	}
}
