using btl_ngk.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace btl_ngk.Controller
{
	public class PhieuNo
	{
		KetNoi kn;

		public PhieuNo()
		{
			kn = new KetNoi();
		}

		public DataTable readDL()
		{
			string sql = "select * from PhieuTraNo";
			return kn.readData(sql);  // Đọc tất cả dữ liệu
		}

		public DataTable timDL(string ma)
		{
			string sql = "select * from PhieuTraNo where MaPhieuTraNo = @ma";
			List<SqlParameter> parameters = new List<SqlParameter>
			{
				new SqlParameter("@ma", ma)
			};
			return kn.readData(sql, parameters);  // Tìm kiếm theo mã phiếu
		}

		public void themDL(string maPhieuTN,DateTime NgayTra, int SoTienTra, string MaHD)
		{
			if(!checkMaTrung(maPhieuTN))
			{
				string insertPTN = "insert into PhieuTraNo values(@maPhieuTN, @NgayTra, @SoTienTra, @MaHD)";
				List<SqlParameter> parameters = new List<SqlParameter>
				{
					new SqlParameter("@maPhieuTN", maPhieuTN),
					new SqlParameter("@NgayTra", NgayTra),
					new SqlParameter("@SoTienTra", SoTienTra),
					new SqlParameter("@MaHD", MaHD)
				};
				kn.CUD(insertPTN, parameters);  // Thêm mới phiếu trả nợ
				MessageBox.Show("Thêm thành công", "Thông báo");
			}
			else
			{
				MessageBox.Show("Mã phiếu trả nợ đã tồn tại");
			}
		}

		public bool checkMaTrung(string ma)
		{
			string sql = "select count(*) from PhieuTraNo where MaPhieuTraNo = @ma";
			List<SqlParameter> parameters = new List<SqlParameter>();
			parameters.Add(new SqlParameter("@ma",ma));
			return kn.kiemTraMaTrung(sql, parameters);
		}
		public void suaDL(string MaPhieuTraNo, DateTime NgayTra, int SoTienTra, string MaHD)
		{
			string updatePTN = "update PhieuTraNo set NgayTra = @NgayTra, SoTienTra = @SoTienTra, MaHD = @MaHD where MaPhieuTraNo = @MaPhieuTraNo";
			List<SqlParameter> parameters = new List<SqlParameter>
			{
				new SqlParameter("@NgayTra", NgayTra),
				new SqlParameter("@SoTienTra", SoTienTra),
				new SqlParameter("@MaHD", MaHD),
				new SqlParameter("@MaPhieuTraNo", MaPhieuTraNo)
			};
			kn.CUD(updatePTN, parameters);  // Cập nhật phiếu trả nợ
			MessageBox.Show("Sửa thành công", "Thông báo");
		}

		public void xoaDL(string MaPhieuTraNo)
		{
			string deletePTN = "delete from PhieuTraNo where MaPhieuTraNo = @MaPhieuTraNo";
			List<SqlParameter> parameters = new List<SqlParameter>
			{
				new SqlParameter("@MaPhieuTraNo", MaPhieuTraNo)
			};
			kn.CUD(deletePTN, parameters);  // Xóa phiếu trả nợ
			MessageBox.Show("Xóa thành công", "Thông báo");
		}
	}
}
