using btl_ngk.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace btl_ngk.Controller
{
	public class PhieuGiaoHang
	{
		public KetNoi kn;

		public PhieuGiaoHang()
		{
			kn = new KetNoi();
		}

		public DataTable readDL()
		{
			string sql = @"SELECT 
                                PhieuGiaoHang.MaPhieuGH AS [Mã phiếu giao hàng], 
                                PhieuGiaoHang.MaDDH AS [Mã đơn đặt hàng], 
                                PhieuGiaoHang.NgayGiao AS [Ngày giao], 
                                ChiTietPhieuGiaoHang.MaNGK AS [Mã nước giải khát], 
                                ChiTietPhieuGiaoHang.SoLuongGiao AS [Số lượng giao], 
                                ChiTietPhieuGiaoHang.DonGiaGiao AS [Đơn giá giao]
                           FROM 
                                PhieuGiaoHang
                           INNER JOIN 
                                ChiTietPhieuGiaoHang
                           ON 
                                PhieuGiaoHang.MaPhieuGH = ChiTietPhieuGiaoHang.MaPhieuGH";

			return kn.readData(sql);
		}

		public void themDL(string MaPhieuGH, string MaDDH, DateTime NgayGiao, string MaNGK, int SoLuongGiao, int DonGiaGiao)
		{
			if (!kiemTraTrungMa(MaPhieuGH, MaNGK))
			{
				string insertPhieuGH = "INSERT INTO PhieuGiaoHang (MaPhieuGH, MaDDH, NgayGiao) VALUES(@MaPhieuGH, @MaDDH, @NgayGiao)";
				List<SqlParameter> parameters1 = new List<SqlParameter>
				{
					new SqlParameter("@MaPhieuGH", MaPhieuGH),
					new SqlParameter("@MaDDH", MaDDH),
					new SqlParameter("@NgayGiao", NgayGiao)
				};

				string insertCTPhieuGH = "INSERT INTO ChiTietPhieuGiaoHang (MaPhieuGH, MaNGK, SoLuongGiao, DonGiaGiao) VALUES(@MaPhieuGH, @MaNGK, @SoLuongGiao, @DonGiaGiao)";
				List<SqlParameter> parameters2 = new List<SqlParameter>
				{
					new SqlParameter("@MaPhieuGH", MaPhieuGH),
					new SqlParameter("@MaNGK", MaNGK),
					new SqlParameter("@SoLuongGiao", SoLuongGiao),
					new SqlParameter("@DonGiaGiao", DonGiaGiao)
				};

				kn.CUD(insertPhieuGH, parameters1);
				kn.CUD(insertCTPhieuGH, parameters2);

				MessageBox.Show("Thêm thành công", "Thông báo");
			}
			else
			{
				MessageBox.Show("Trùng mã phiếu giao hàng hoặc mã nước giải khát", "Thông báo");
			}
		}

		public bool kiemTraTrungMa(string MaPhieuGH, string MaNGK)
		{
			string checkPhieuGH = "SELECT COUNT(0) FROM PhieuGiaoHang WHERE MaPhieuGH = @MaPhieuGH";
			string checkCTPhieuGH = "SELECT COUNT(0) FROM ChiTietPhieuGiaoHang WHERE MaPhieuGH = @MaPhieuGH AND MaNGK = @MaNGK";

			List<SqlParameter> parameters1 = new List<SqlParameter> { new SqlParameter("@MaPhieuGH", MaPhieuGH) };
			if (kn.kiemTraMaTrung(checkPhieuGH, parameters1)) return true;

			List<SqlParameter> parameters2 = new List<SqlParameter>
			{
				new SqlParameter("@MaPhieuGH", MaPhieuGH),
				new SqlParameter("@MaNGK", MaNGK)
			};
			if (kn.kiemTraMaTrung(checkCTPhieuGH, parameters2)) return true;

			return false;
		}

		public void xoaDL(string MaPhieuGH, string MaNGK)
		{
			string deleteCTPhieuGH = "DELETE FROM ChiTietPhieuGiaoHang WHERE MaPhieuGH = @MaPhieuGH AND MaNGK = @MaNGK";
			string deletePhieuGH = "DELETE FROM PhieuGiaoHang WHERE MaPhieuGH = @MaPhieuGH";

			List<SqlParameter> parameters1 = new List<SqlParameter>
			{
				new SqlParameter("@MaPhieuGH", MaPhieuGH),
				new SqlParameter("@MaNGK", MaNGK)
			};

			List<SqlParameter> parameters2 = new List<SqlParameter> { new SqlParameter("@MaPhieuGH", MaPhieuGH) };

			kn.CUD(deleteCTPhieuGH, parameters1);
			kn.CUD(deletePhieuGH, parameters2);
			MessageBox.Show("Xóa thông tin thành công", "Thông báo");
		}

		public void suaDL(string MaPhieuGH, string MaDDH, DateTime NgayGiao, string MaNGK, int SoLuongGiao, int DonGiaGiao)
		{
			string updateCTPhieuGH = "UPDATE ChiTietPhieuGiaoHang SET SoLuongGiao = @SoLuongGiao, DonGiaGiao = @DonGiaGiao WHERE MaPhieuGH = @MaPhieuGH AND MaNGK = @MaNGK";
			string updatePhieuGH = "UPDATE PhieuGiaoHang SET MaDDH = @MaDDH, NgayGiao = @NgayGiao WHERE MaPhieuGH = @MaPhieuGH";

			List<SqlParameter> parameters1 = new List<SqlParameter>
			{
				new SqlParameter("@MaPhieuGH", MaPhieuGH),
				new SqlParameter("@MaNGK", MaNGK),
				new SqlParameter("@SoLuongGiao", SoLuongGiao),
				new SqlParameter("@DonGiaGiao", DonGiaGiao)
			};

			List<SqlParameter> parameters2 = new List<SqlParameter>
			{
				new SqlParameter("@MaPhieuGH", MaPhieuGH),
				new SqlParameter("@MaDDH", MaDDH),
				new SqlParameter("@NgayGiao", NgayGiao)
			};

			kn.CUD(updateCTPhieuGH, parameters1);
			kn.CUD(updatePhieuGH, parameters2);
			MessageBox.Show("Sửa thông tin thành công","Thông báo");
		}

		public DataTable timKiem(string maPGH)
		{
			string tim = @"SELECT 
                                PhieuGiaoHang.MaPhieuGH AS [Mã phiếu giao hàng], 
                                PhieuGiaoHang.MaDDH AS [Mã đơn đặt hàng], 
                                PhieuGiaoHang.NgayGiao AS [Ngày giao], 
                                ChiTietPhieuGiaoHang.MaNGK AS [Mã nước giải khát], 
                                ChiTietPhieuGiaoHang.SoLuongGiao AS [Số lượng giao], 
                                ChiTietPhieuGiaoHang.DonGiaGiao AS [Đơn giá giao]
                           FROM 
                                PhieuGiaoHang
                           INNER JOIN 
                                ChiTietPhieuGiaoHang
                           ON 
                                PhieuGiaoHang.MaPhieuGH = ChiTietPhieuGiaoHang.MaPhieuGH 
                           WHERE 
                                PhieuGiaoHang.MaPhieuGH = @maPGH";
			List<SqlParameter> parameters = new List<SqlParameter>
			{
				new SqlParameter("@maPGH", maPGH)
			};
			return kn.readData(tim, parameters);
		}
	}
}
