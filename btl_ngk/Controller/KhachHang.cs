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
	public class KhachHang
	{
		private KetNoi kn;
		public KhachHang()
		{
			kn = new KetNoi();
		}

		public DataTable readDL()
		{
			string sql = "select * from KhachHang";
			return kn.readData(sql);
		}

		public void themDL(string MaKH, string TenKH, string DiaChi, string SDT)
		{
			// Kiểm tra thông tin khách hàng
			if (string.IsNullOrEmpty(MaKH) || string.IsNullOrEmpty(TenKH) || string.IsNullOrEmpty(DiaChi) || string.IsNullOrEmpty(SDT))
			{
				MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo");
				return;
			}

			// Kiểm tra mã khách hàng đã tồn tại
			if (checkMa(MaKH))
			{
				MessageBox.Show("Mã khách hàng đã tồn tại", "Thông báo");
				return;
			}

			string sql = "insert into KhachHang (MaKH, TenKH, DiaChi, SDT) values(@MaKH, @TenKH, @DiaChi, @SDT)";
			List<SqlParameter> parameters = new List<SqlParameter>
			{
				new SqlParameter("@MaKH", MaKH),
				new SqlParameter("@TenKH", TenKH),
				new SqlParameter("@DiaChi", DiaChi),
				new SqlParameter("@SDT", SDT)
			};
			kn.CUD(sql, parameters);
			MessageBox.Show("Thêm khách hàng thành công", "Thông báo");
		}

		public bool checkMa(string makh)
		{
			string sql = "select count(*) from KhachHang where MaKH = @MaKH";
			List<SqlParameter> parameters = new List<SqlParameter>
			{
				new SqlParameter("@MaKH", makh)
			};
			int count = (int)kn.readData(sql, parameters).Rows[0][0];
			return count > 0;
		}

		public void suaDL(string MaKH, string TenKH, string DiaChi, string SDT)
		{
			// Kiểm tra nếu khách hàng không tồn tại
			if (!checkMa(MaKH))
			{
				MessageBox.Show("Mã khách hàng không tồn tại", "Thông báo");
				return;
			}

			string sql = "update KhachHang set TenKH = @TenKH, DiaChi = @DiaChi, SDT = @SDT where MaKH = @MaKH";
			List<SqlParameter> parameters = new List<SqlParameter>
			{
				new SqlParameter("@MaKH", MaKH),
				new SqlParameter("@TenKH", TenKH),
				new SqlParameter("@DiaChi", DiaChi),
				new SqlParameter("@SDT", SDT)
			};
			kn.CUD(sql, parameters);
			MessageBox.Show("Cập nhật thông tin khách hàng thành công", "Thông báo");
		}

		public void xoaDL(string MaKH)
		{
			KetNoi kn = new KetNoi();

			// Kiểm tra nếu mã khách hàng không tồn tại
			string sqlCheckMa = "SELECT COUNT(*) FROM KhachHang WHERE MaKH = @MaKH";
			List<SqlParameter> checkParams = new List<SqlParameter>
			{
				new SqlParameter("@MaKH", MaKH)
			};
			if (!kn.kiemTraMaTrung(sqlCheckMa, checkParams))
			{
				MessageBox.Show("Mã khách hàng không tồn tại", "Thông báo");
				return;
			}

			// Xóa khách hàng (dữ liệu liên quan sẽ tự động bị xóa do ON DELETE CASCADE)
			string deleteKH = "DELETE FROM KhachHang WHERE MaKH = @MaKH";

			// Tạo một bản sao mới của danh sách tham số
			List<SqlParameter> deleteParams = new List<SqlParameter>
			{
				new SqlParameter("@MaKH", MaKH)
			};

			// Thực hiện lệnh xóa
			kn.CUD(deleteKH, deleteParams);

			MessageBox.Show("Xóa khách hàng thành công", "Thông báo");
		}



	}
}
