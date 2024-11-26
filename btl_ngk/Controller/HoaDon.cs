using btl_ngk.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace btl_ngk.Controller
{
	public class HoaDon
	{
		KetNoi kn;

		public HoaDon()
		{
			kn = new KetNoi();
		}

		public string readText(string sql)
		{
			return kn.readText(sql);
		}

		public DataTable readDL()
		{
			string sql = "SELECT HoaDon.MaHD, HoaDon.NgayLapHD, HoaDon.MaKH, " +
						 "ChiTietHoaDon.MaNGK, ChiTietHoaDon.SoLuongMua, ChiTietHoaDon.DonGiaBan " +
						 "FROM HoaDon " +
						 "INNER JOIN ChiTietHoaDon ON HoaDon.MaHD = ChiTietHoaDon.MaHD";
			return kn.readData(sql);
		}

		public void themDL(string MaHD, DateTime NgayLapHD, string MaKH, string MaNGK, int SoLuongMua, int DonGiaBan, string TenKH, string DiaChi, string SDT)
		{
			if (checkMa(MaHD, MaNGK))
			{
				MessageBox.Show("Mã hóa đơn hoặc mã nước giải khát đã tồn tại!", "Cảnh báo");
				return;
			}

			// Insert into HoaDon table
			string insertHD = "INSERT INTO HoaDon (MaHD, NgayLapHD, MaKH) VALUES (@MaHD, @NgayLapHD, @MaKH)";
			// Insert into ChiTietHoaDon table
			string insertChiTietHD = "INSERT INTO ChiTietHoaDon (MaHD, MaNGK, SoLuongMua, DonGiaBan) VALUES (@MaHD, @MaNGK, @SoLuongMua, @DonGiaBan)";

			List<SqlParameter> parameters1 = new List<SqlParameter>
			{
				new SqlParameter("@MaHD", MaHD),
				new SqlParameter("@NgayLapHD", NgayLapHD),
				new SqlParameter("@MaKH", MaKH)
			};

			List<SqlParameter> parameters2 = new List<SqlParameter>
			{
				new SqlParameter("@MaHD", MaHD),
				new SqlParameter("@MaNGK", MaNGK),
				new SqlParameter("@SoLuongMua", SoLuongMua),
				new SqlParameter("@DonGiaBan", DonGiaBan)
			};

			kn.CUD(insertHD, parameters1);
			kn.CUD(insertChiTietHD, parameters2);

			MessageBox.Show("In hóa đơn thành công!", "Thông báo");
		}

		private bool checkMa(string mahd, string mangk)
		{
			string checkMaHD = "SELECT COUNT(0) FROM HoaDon WHERE MaHD = @MaHD";
			string checkCTHD = "SELECT COUNT(0) FROM ChiTietHoaDon WHERE MaHD = @MaHD AND MaNGK = @MaNGK";

			List<SqlParameter> parameters1 = new List<SqlParameter>
			{
				new SqlParameter("@MaHD", mahd)
			};

			List<SqlParameter> parameters2 = new List<SqlParameter>
			{
				new SqlParameter("@MaHD", mahd),
				new SqlParameter("@MaNGK", mangk)
			};

			if (kn.kiemTraMaTrung(checkMaHD, parameters1) || kn.kiemTraMaTrung(checkCTHD, parameters2))
			{
				return true;
			}
			return false;
		}

		public void xoaDL(string mahd, string mangk)
		{
			string deleteCTDonDH = "DELETE FROM ChiTietHoaDon WHERE MaHD = @MaHD AND MaNGK = @MaNGK";
			List<SqlParameter> parameters2 = new List<SqlParameter>
			{
				new SqlParameter("@MaHD", mahd),
				new SqlParameter("@MaNGK", mangk)
			};
			kn.CUD(deleteCTDonDH, parameters2);

			string deleteDonDH = "DELETE FROM HoaDon WHERE MaHD = @MaHD";
			List<SqlParameter> parameters1 = new List<SqlParameter>
			{
				new SqlParameter("@MaHD", mahd)
			};
			kn.CUD(deleteDonDH, parameters1);
		}

		public void suaDL(string MaHD, DateTime NgayLapHD, string MaKH, string MaNGK, int SoLuongMua, int DonGiaBan, string TenKH, string DiaChi, string SDT)
		{
			// Update ChiTietHoaDon
			string updateCTDonDH = "UPDATE ChiTietHoaDon SET SoLuongMua = @SoLuongMua, DonGiaBan = @DonGiaBan WHERE MaHD = @MaHD AND MaNGK = @MaNGK";
			List<SqlParameter> parametersCT = new List<SqlParameter>
			{
				new SqlParameter("@MaHD", MaHD),
				new SqlParameter("@SoLuongMua", SoLuongMua),
				new SqlParameter("@DonGiaBan", DonGiaBan),
				new SqlParameter("@MaNGK", MaNGK)
			};
			kn.CUD(updateCTDonDH, parametersCT);

			// Update HoaDon
			string updateDonDH = "UPDATE HoaDon SET NgayLapHD = @NgayLapHD, MaKH = @MaKH WHERE MaHD = @MaHD";
			List<SqlParameter> parametersHD = new List<SqlParameter>
			{
				new SqlParameter("@NgayLapHD", NgayLapHD),
				new SqlParameter("@MaKH", MaKH),
				new SqlParameter("@MaHD", MaHD)
			};
			kn.CUD(updateDonDH, parametersHD);
			MessageBox.Show("Sửa thông tin hóa đơn thành công", "Thông báo");
		}

		public DataTable timKiemMaHD(string maHD)
		{
			string sql = "SELECT HoaDon.MaHD, HoaDon.NgayLapHD, HoaDon.MaKH, " +
						 "ChiTietHoaDon.MaNGK, ChiTietHoaDon.SoLuongMua, ChiTietHoaDon.DonGiaBan " +
						 "FROM HoaDon " +
						 "INNER JOIN ChiTietHoaDon ON HoaDon.MaHD = ChiTietHoaDon.MaHD " +
						 "WHERE HoaDon.MaHD = @MaHD";
			List<SqlParameter> parameters = new List<SqlParameter>
			{
				new SqlParameter("@MaHD", maHD)
			};
			return kn.readData(sql, parameters);
		}
	}
}
