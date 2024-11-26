using btl_ngk.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btl_ngk.Controller
{
	internal class DonDatHang
	{
		KetNoi kn;
		public DonDatHang()
		{
			kn = new KetNoi();
		}

		public string readText(string text)
		{
			return kn.readText(text);
		}

		public DataTable readMa()
		{
			string sql = "select * from DonDatHang";
			return kn.readData(sql);
		}

		public DataTable readDL()
		{
			string sql = "select DonDatHang.MaDDH as [Mã DDH], " +
						 "DonDatHang.NgayDH as [Ngày DH], " +
						 "NhaCungCap.TenNCC as [Nhà Cung cấp], " +
						 "NuocGiaiKhat.TenNGK as [Tên NGK], " +
						 "ChiTietDonDatHang.SoLuongDat as [Số lượng đặt] " +
						 "from DonDatHang " +
						 "inner join NhaCungCap on DonDatHang.MaNCC = NhaCungCap.MaNCC " +
						 "inner join ChiTietDonDatHang on DonDatHang.MaDDH = ChiTietDonDatHang.MaDDH " +
						 "inner join NuocGiaiKhat on ChiTietDonDatHang.MaNGK = NuocGiaiKhat.MaNGK";
			return kn.readData(sql);
		}

		public void themDL(string maddh, DateTime ngaydh, string mancc, string mangk, int soluongdat)
		{
			if (checkMa(maddh, mangk))
			{
				MessageBox.Show("Mã đơn đặt hàng hoặc mã nước giải khát đã tồn tại!", "Cảnh báo");
				return;
			}

			string insertDonDDH = "insert into DonDatHang (MaDDH, NgayDH, MaNCC) values(@maddh, @ngaydh, @mancc)";
			string insertChiTietDonDatHang = "insert into ChiTietDonDatHang (MaDDH, MaNGK, SoLuongDat) values(@maddh, @mangk, @soluongdat)";

			List<SqlParameter> parameters1 = new List<SqlParameter>
			{
				new SqlParameter("@maddh", maddh),
				new SqlParameter("@ngaydh", ngaydh),
				new SqlParameter("@mancc", mancc)
			};

			List<SqlParameter> parameters2 = new List<SqlParameter>
			{
				new SqlParameter("@maddh", maddh),
				new SqlParameter("@mangk", mangk),
				new SqlParameter("@soluongdat", soluongdat)
			};

			kn.CUD(insertDonDDH, parameters1);
			kn.CUD(insertChiTietDonDatHang, parameters2);
			MessageBox.Show("Đơn đặt hàng đã được thêm thành công!", "Thông báo");
		}

		private bool checkMa(string maddh, string mangk)
		{
			string checkMaDDH = "select count(0) from DonDatHang where MaDDH = @maddh";
			string checkCTDDH = "select count(0) from ChiTietDonDatHang where MaDDH = @maddh and MaNGK = @mangk";

			List<SqlParameter> parameters1 = new List<SqlParameter>
			{
				new SqlParameter("@maddh", maddh)
			};

			if (kn.kiemTraMaTrung(checkMaDDH, parameters1))
			{
				return true;
			}

			List<SqlParameter> parameters2 = new List<SqlParameter>
			{
				new SqlParameter("@maddh", maddh),
				new SqlParameter("@mangk", mangk)
			};

			if (kn.kiemTraMaTrung(checkCTDDH, parameters2))
			{
				return true;
			}

			return false;
		}

		public void xoaDL(string maddh, string mangk)
		{
			string deleteCTDonDH = "delete from ChiTietDonDatHang where MaDDH = @maddh and MaNGK = @mangk";
			List<SqlParameter> parameters2 = new List<SqlParameter>
			{
				new SqlParameter("@maddh", maddh),
				new SqlParameter("@mangk", mangk)
			};
			kn.CUD(deleteCTDonDH, parameters2);

			string deleteDonDH = "delete from DonDatHang where MaDDH = @maddh";
			List<SqlParameter> parameters1 = new List<SqlParameter>
			{
				new SqlParameter("@maddh", maddh)
			};
			kn.CUD(deleteDonDH, parameters1);
		}

		public void suaDL(string maddh, DateTime ngaydh, string mancc, string mangk, int soluongdat)
		{
			string updateCTDonDH = "update ChiTietDonDatHang set MaNGK = @mangk, SoLuongDat = @soluongdat where MaDDH = @maddh";
			List<SqlParameter> parameters2 = new List<SqlParameter>
			{
				new SqlParameter("@maddh", maddh),
				new SqlParameter("@soluongdat", soluongdat),
				new SqlParameter("@mangk", mangk)
			};
			kn.CUD(updateCTDonDH, parameters2);

			string updateDonDH = "update DonDatHang set NgayDH = @ngaydh, MaNCC = @mancc where MaDDH = @maddh";
			List<SqlParameter> parameters1 = new List<SqlParameter>
			{
				new SqlParameter("@ngaydh", ngaydh),
				new SqlParameter("@mancc", mancc),
				new SqlParameter("@maddh", maddh)
			};
			kn.CUD(updateDonDH, parameters1);
		}
	}
}
