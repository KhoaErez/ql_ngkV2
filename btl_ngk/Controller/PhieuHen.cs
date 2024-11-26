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
	public class PhieuHen
	{
		KetNoi kn;

		public PhieuHen()
		{
			kn = new KetNoi();
		}

		public DataTable readDL()
		{
			string sql = "SELECT PhieuHen.MaPhieuHen, PhieuHen.MaKH, PhieuHen.NgayLap, PhieuHen.NgayHen, " +
						 "ChiTietPhieuHen.MaNGK, ChiTietPhieuHen.SoLuongHen " +
						 "FROM PhieuHen " +
						 "INNER JOIN ChiTietPhieuHen ON PhieuHen.MaPhieuHen = ChiTietPhieuHen.MaPhieuHen";
			return kn.readData(sql);
		}

		public DataTable timTheoMa(string ma)
		{
			string sql = "SELECT PhieuHen.MaPhieuHen, PhieuHen.MaKH, PhieuHen.NgayLap, PhieuHen.NgayHen, " +
						 "ChiTietPhieuHen.MaNGK, ChiTietPhieuHen.SoLuongHen " +
						 "FROM PhieuHen " +
						 "INNER JOIN ChiTietPhieuHen ON PhieuHen.MaPhieuHen = ChiTietPhieuHen.MaPhieuHen " +
						 "WHERE PhieuHen.MaPhieuHen = @ma";
			List<SqlParameter> parameters = new List<SqlParameter>
			{
				new SqlParameter("@ma", ma)
			};
			return kn.readData(sql, parameters);
		}

		public void themDL(string MaPhieuHen,string MaKH, DateTime NgayLap, DateTime NgayHen, string MaNGK, int SoLuongHen)
		{
			if (checkMa(MaPhieuHen))
			{
				MessageBox.Show("Mã Phiếu hẹn đã tồn tại", "Thông báo");
				return;
			}
			else
			{
				// Thêm vào bảng PhieuHen
				string insertPhieuHen = "INSERT INTO PhieuHen " +
										"VALUES(@MaPhieuHen, @MaKH, @NgayLap, @NgayHen)";

					List<SqlParameter> parameters1 = new List<SqlParameter>
					{
						new SqlParameter("@MaPhieuHen", MaPhieuHen),
						new SqlParameter("@MaKH", MaKH),
						new SqlParameter("@NgayLap", NgayLap),
						new SqlParameter("@NgayHen", NgayHen)
					};

					kn.CUD(insertPhieuHen, parameters1);

					// Thêm vào ChiTietPhieuHen
					string insertChiTietPhieuHen = "INSERT INTO ChiTietPhieuHen " +
												   "VALUES(@MaPhieuHen, @MaNGK, @SoLuongHen)";

					List<SqlParameter> parameters2 = new List<SqlParameter>
					{
						new SqlParameter("@MaPhieuHen", MaPhieuHen),
						new SqlParameter("@MaNGK", MaNGK),
						new SqlParameter("@SoLuongHen", SoLuongHen)
					};

					kn.CUD(insertChiTietPhieuHen, parameters2);
					MessageBox.Show("Thêm phiếu hẹn thành công","Thông báo");
			}	
			
		}

		public bool checkMa(string MaPhieuHen)
		{
			string sql = "select count(*) from PhieuHen where MaPhieuHen = @MaPhieuHen";
			List<SqlParameter> parameters = new List<SqlParameter>();
			parameters.Add(new SqlParameter("@MaPhieuHen", MaPhieuHen));
			bool dt = kn.kiemTraMaTrung(sql, parameters);
			if (dt)
			{
				return true;
			}
			return false;
		}

		public void xoaDL(string MaPhieuHen, string MaNGK)
		{
			string deleteCTPhieuHen = "DELETE FROM ChiTietPhieuHen WHERE MaPhieuHen = @MaPhieuHen AND MaNGK = @MaNGK";
			List<SqlParameter> parameters2 = new List<SqlParameter>
			{
				new SqlParameter("@MaPhieuHen", MaPhieuHen),
				new SqlParameter("@MaNGK", MaNGK)
			};
			kn.CUD(deleteCTPhieuHen, parameters2);

			string deletePhieuHen = "DELETE FROM PhieuHen WHERE MaPhieuHen = @MaPhieuHen";
			List<SqlParameter> parameters1 = new List<SqlParameter>
			{
				new SqlParameter("@MaPhieuHen", MaPhieuHen)
			};
			kn.CUD(deletePhieuHen, parameters1);
			MessageBox.Show("Xóa phiếu hẹn thành công", "Thông báo");
		}

		public void suaDL(string MaPhieuHen, string MaKH, DateTime NgayLap, DateTime NgayHen, string MaNGK, int SoLuongHen)
		{
			string updateCTPhieuHen = "UPDATE ChiTietPhieuHen SET SoLuongHen = @SoLuongHen " +
									   "WHERE MaPhieuHen = @MaPhieuHen AND MaNGK = @MaNGK";
			List<SqlParameter> parameters2 = new List<SqlParameter>
			{
				new SqlParameter("@MaPhieuHen", MaPhieuHen),
				new SqlParameter("@SoLuongHen", SoLuongHen),
				new SqlParameter("@MaNGK", MaNGK)
			};
			kn.CUD(updateCTPhieuHen, parameters2);

			string updatePhieuHen = "UPDATE PhieuHen SET MaKH = @MaKH, NgayLap = @NgayLap, NgayHen = @NgayHen " +
									"WHERE MaPhieuHen = @MaPhieuHen";
			List<SqlParameter> parameters1 = new List<SqlParameter>
			{
				new SqlParameter("@NgayHen", NgayHen),
				new SqlParameter("@NgayLap", NgayLap),
				new SqlParameter("@MaKH", MaKH),
				new SqlParameter("@MaPhieuHen", MaPhieuHen)
			};
			kn.CUD(updatePhieuHen, parameters1);
			MessageBox.Show("Sửa phiếu hẹn thành công", "Thông báo");
		}
	}
}
