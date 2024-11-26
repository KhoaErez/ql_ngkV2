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
	public partial class frmThongKe_DoanhSo : Form
	{
		ThongKe tk = new ThongKe();
		public frmThongKe_DoanhSo()
		{
			InitializeComponent();
			UpdateDataGridView();
		}

		private void UpdateDataGridView()
		{
			int month = dtpTK.Value.Month;
			int year = dtpTK.Value.Year;
			dgvDoanhSo.DataSource = tk.thongKeDoanhSo(month, year);
			decimal tongTien = TinhTongTien();
			txtTongTien.Text = tongTien.ToString("N0") + " VND";
		}


		private decimal TinhTongTien()
		{
			// Thực hiện tính toán tổng tiền từ bảng ChiTietHoaDon
			string sql = "SELECT SUM(SoLuongMua * DonGiaBan) AS TongTien FROM ChiTietHoaDon";
			DataTable dtTongTien = tk.readDL(sql);
			if (dtTongTien.Rows.Count > 0 && dtTongTien.Rows[0]["TongTien"] != DBNull.Value)
			{
				return Convert.ToDecimal(dtTongTien.Rows[0]["TongTien"]);
			}
			return 0;
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void dtpTK_ValueChanged(object sender, EventArgs e)
		{
			UpdateDataGridView();
		}
	}
}
