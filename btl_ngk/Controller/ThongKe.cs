using btl_ngk.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btl_ngk.Controller
{
	internal class ThongKe
	{
		KetNoi kn;
		public ThongKe()
		{
			kn = new KetNoi();
		}

		public DataTable readDL(string sql)
		{
			return kn.readData(sql);
		}

		public DataTable thongKeBanChay()
		{
			string sql = "SELECT[MaHD],[MaNGK],[SoLuongMua],[DonGiaBan] FROM ChiTietHoaDon ORDER BY SoLuongMua DESC";
			return kn.readData(sql);
		}

		public DataTable thongKeDoanhSo(int month, int year)
		{
			string sql = "SELECT ChiTietHoaDon.MaHD, ChiTietHoaDon.MaNGK, ChiTietHoaDon.SoLuongMua, ChiTietHoaDon.DonGiaBan, HoaDon.NgayLapHD " +
						 "FROM ChiTietHoaDon INNER JOIN HoaDon ON ChiTietHoaDon.MaHD = HoaDon.MaHD " +
						 "WHERE MONTH(HoaDon.NgayLapHD) = @month AND YEAR(HoaDon.NgayLapHD) = @year " +
						 "ORDER BY ChiTietHoaDon.SoLuongMua DESC";
			List<SqlParameter> parameters = new List<SqlParameter>();
			parameters.Add(new SqlParameter("@month", month));
			parameters.Add(new SqlParameter("@year", year));
			return kn.readData(sql,parameters);
		}
	}
}
