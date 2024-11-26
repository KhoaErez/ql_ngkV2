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
	public class NuocGiaiKhat
	{
		private KetNoi kn;
		public NuocGiaiKhat()
		{
			kn = new KetNoi();
		}

		public DataTable readDL()
		{
			string sql = "select * from NuocGiaiKhat";
			return kn.readData(sql);
		}

		public void themDL(string MaNGK, string TenNGK, string MaLoai, int DonGia)
		{
			if (checkMa(MaNGK))
			{
				MessageBox.Show("Trùng mã", "Thông báo");
			}
			else
			{
				string sql = "insert into NuocGiaiKhat values(@MaNGK,@TenNGK,@MaLoai,@DonGia)";
				List<SqlParameter> parameters = new List<SqlParameter>
				{
					new SqlParameter("@MaNGK", MaNGK),
					new SqlParameter("@TenNGK", TenNGK),
					new SqlParameter("@MaLoai", MaLoai),
					new SqlParameter("@DonGia", DonGia)
				};
				kn.CUD(sql, parameters);
				MessageBox.Show("Thêm thành công", "Thông báo");
			}
		}

		public bool checkMa(string MaNGK)
		{
			string sql = "select count(*) from NuocGiaiKhat where MaNGK = @MaNGK";
			List<SqlParameter> parameters = new List<SqlParameter>
			{
				new SqlParameter("@MaNGK", MaNGK)
			};
			bool dt = kn.kiemTraMaTrung(sql, parameters);
			return dt;  
		}

		// Sửa lại phần xóa để tránh lỗi khi xóa
		public void xoaDL(string MaNGK)
		{
			try
			{
				// Kiểm tra mã nước giải khát
				if (string.IsNullOrEmpty(MaNGK))
				{
					MessageBox.Show("Vui lòng chọn mã nước giải khát cần xóa!", "Thông báo");
					return;
				}

				// Kiểm tra xem mã nước giải khát có liên quan dữ liệu ở các bảng khác không
				string sqlCheck = @"
						SELECT COUNT(*) FROM (
							SELECT MaNGK FROM ChiTietDonDatHang WHERE MaNGK = @MaNGK
							UNION ALL
							SELECT MaNGK FROM ChiTietPhieuGiaoHang WHERE MaNGK = @MaNGK
							UNION ALL
							SELECT MaNGK FROM ChiTietPhieuHen WHERE MaNGK = @MaNGK
							UNION ALL
							SELECT MaNGK FROM ChiTietHoaDon WHERE MaNGK = @MaNGK
						) AS RelatedData";

				List<SqlParameter> checkParams = new List<SqlParameter>
				{
					new SqlParameter("@MaNGK", MaNGK)
				};

				bool relatedCount = kn.kiemTraMaTrung(sqlCheck, checkParams);

				if (relatedCount)
				{
					MessageBox.Show("Không thể xóa nước giải khát vì có dữ liệu liên quan trong bảng Phiếu Giao Hàng hoặc Hóa Đơn hoặc Đơn Đặt Hàng!", "Thông báo");
					return;
				}

				// Thực hiện xóa nước giải khát nếu không có dữ liệu liên quan
				string sqlDelete = "DELETE FROM NuocGiaiKhat WHERE MaNGK = @MaNGK";
				List<SqlParameter> deleteParams = new List<SqlParameter>
				{
					new SqlParameter("@MaNGK", MaNGK)
				};

				kn.CUD(sqlDelete, deleteParams);

					MessageBox.Show("Xóa nước giải khát thành công!", "Thông báo");
				}
			catch (SqlException ex)
			{
				MessageBox.Show("Lỗi khi xóa nước giải khát: " + ex.Message, "Thông báo");
			}
		}


		public void suaDL(string MaNGK, string TenNGK, string MaLoai, int DonGia)
		{
			if (string.IsNullOrEmpty(MaNGK)) // Kiểm tra mã nước giải khát có tồn tại không
			{
				MessageBox.Show("Vui lòng chọn thông tin cần sửa!", "Thông báo");
				return;
			}

			string sql = "update NuocGiaiKhat set TenNGK = @TenNGK, MaLoai = @MaLoai, DonGia = @DonGia where MaNGK = @MaNGK";
			List<SqlParameter> parameters = new List<SqlParameter>
			{
				new SqlParameter("@MaNGK", MaNGK),
				new SqlParameter("@TenNGK", TenNGK),
				new SqlParameter("@MaLoai", MaLoai),
				new SqlParameter("@DonGia", DonGia)
			};
			kn.CUD(sql, parameters);
			MessageBox.Show("Sửa thành công", "Thông báo");
		}
	}
}
