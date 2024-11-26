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
	public class LoaiNuocGK
	{
		private KetNoi kn;

		public LoaiNuocGK()
		{
			kn = new KetNoi();
		}

		public DataTable readDL()
		{
			string sql = "SELECT * FROM LoaiNuocGiaiKhat";
			return kn.readData(sql);
		}

		public void themDL(string MaLoai, string TenLoai, string MaNCC)
		{
			if (checkMa(MaLoai))
			{
				MessageBox.Show("Trùng mã", "Thông báo");
			}
			else
			{
				string sql = "INSERT INTO LoaiNuocGiaiKhat (MaLoai, TenLoai, MaNCC) VALUES (@MaLoai, @TenLoai, @MaNCC)";
				List<SqlParameter> parameters = new List<SqlParameter>
				{
					new SqlParameter("@MaLoai", MaLoai),
					new SqlParameter("@TenLoai", TenLoai),
					new SqlParameter("@MaNCC", MaNCC)
				};
				kn.CUD(sql, parameters);
				MessageBox.Show("Thêm thành công", "Thông báo");
			}
		}

		public bool checkMa(string MaLoai)
		{
			string sql = "SELECT COUNT(*) FROM LoaiNuocGiaiKhat WHERE MaLoai = @MaLoai";
			List<SqlParameter> parameters = new List<SqlParameter>
			{
				new SqlParameter("@MaLoai", MaLoai)
			};
			return kn.kiemTraMaTrung(sql, parameters);
		}

		public void xoaDL(string MaLoai)
		{
			string sql = "DELETE FROM LoaiNuocGiaiKhat WHERE MaLoai = @MaLoai";
			List<SqlParameter> parameters = new List<SqlParameter>
			{
				new SqlParameter("@MaLoai", MaLoai)
			};
			kn.CUD(sql, parameters);
			MessageBox.Show("Xóa thành công", "Thông báo");
		}

		public void suaDL(string MaLoai, string TenLoai, string MaNCC)
		{
			string sql = "UPDATE LoaiNuocGiaiKhat SET TenLoai = @TenLoai, MaNCC = @MaNCC WHERE MaLoai = @MaLoai";
			List<SqlParameter> parameters = new List<SqlParameter>
			{
				new SqlParameter("@MaLoai", MaLoai),
				new SqlParameter("@TenLoai", TenLoai),
				new SqlParameter("@MaNCC", MaNCC)
			};
			kn.CUD(sql, parameters);
			MessageBox.Show("Sửa thành công", "Thông báo");
		}
	}
}
