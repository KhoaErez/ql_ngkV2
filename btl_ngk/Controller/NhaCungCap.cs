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
	public class NhaCungCap
	{
		private KetNoi kn;
		public NhaCungCap()
		{
			kn = new KetNoi();
		}

		public DataTable readDL()
		{
			string sql = "select * from NhaCungCap";
			return kn.readData(sql);
		}

		public void themDL(string MaNCC, string TenNCC, string DiaChi, string SDT)
		{
			if (checkMa(MaNCC))
			{
				MessageBox.Show("Mã nhà cung cấp đã tồn tại", "Thông báo");
			}
			else
			{
				string sql = "insert into NhaCungCap values(@MaNCC, @TenNCC, @DiaChi, @SDT)";
				List<SqlParameter> parameters = new List<SqlParameter>
				{
					new SqlParameter("@MaNCC", MaNCC),
					new SqlParameter("@TenNCC", TenNCC),
					new SqlParameter("@DiaChi", DiaChi),
					new SqlParameter("@SDT", SDT)
				};
				kn.CUD(sql, parameters);
				MessageBox.Show("Thêm thành công", "Thông báo");
			}
		}

		public bool checkMa(string MaNCC)
		{
			string sql = "select count(*) from NhaCungCap where MaNCC = @MaNCC";
			List<SqlParameter> parameters = new List<SqlParameter>
			{
				new SqlParameter("@MaNCC", MaNCC)
			};
			bool exists = kn.kiemTraMaTrung(sql, parameters);
			return exists;
		}

		public void xoaDL(string MaNCC)
		{
			// Xóa dữ liệu từ các bảng con theo thứ tự phụ thuộc
			string deleteChiTietPhieuGiaoHang = "DELETE FROM ChiTietPhieuGiaoHang WHERE MaNGK IN (SELECT MaNGK FROM NuocGiaiKhat WHERE MaLoai IN (SELECT MaLoai FROM LoaiNuocGiaiKhat WHERE MaNCC = @MaNCC))";
			string deleteChiTietDonDatHang = "DELETE FROM ChiTietDonDatHang WHERE MaNGK IN (SELECT MaNGK FROM NuocGiaiKhat WHERE MaLoai IN (SELECT MaLoai FROM LoaiNuocGiaiKhat WHERE MaNCC = @MaNCC))";
			string deletePhieuGiaoHang = "DELETE FROM PhieuGiaoHang WHERE MaDDH IN (SELECT MaDDH FROM DonDatHang WHERE MaNCC = @MaNCC)";
			string deleteDonDatHang = "DELETE FROM DonDatHang WHERE MaNCC = @MaNCC";
			string deleteNuocGiaiKhat = "DELETE FROM NuocGiaiKhat WHERE MaLoai IN (SELECT MaLoai FROM LoaiNuocGiaiKhat WHERE MaNCC = @MaNCC)";
			string deleteLoaiNuocGiaiKhat = "DELETE FROM LoaiNuocGiaiKhat WHERE MaNCC = @MaNCC";
			string deleteNCC = "DELETE FROM NhaCungCap WHERE MaNCC = @MaNCC";

			// Thực hiện xóa từng bảng theo thứ tự
			kn.CUD(deleteChiTietPhieuGiaoHang, new List<SqlParameter> { new SqlParameter("@MaNCC", MaNCC) });
			kn.CUD(deleteChiTietDonDatHang, new List<SqlParameter> { new SqlParameter("@MaNCC", MaNCC) });
			kn.CUD(deletePhieuGiaoHang, new List<SqlParameter> { new SqlParameter("@MaNCC", MaNCC) });
			kn.CUD(deleteDonDatHang, new List<SqlParameter> { new SqlParameter("@MaNCC", MaNCC) });
			kn.CUD(deleteNuocGiaiKhat, new List<SqlParameter> { new SqlParameter("@MaNCC", MaNCC) });
			kn.CUD(deleteLoaiNuocGiaiKhat, new List<SqlParameter> { new SqlParameter("@MaNCC", MaNCC) });

			// Cuối cùng, xóa nhà cung cấp
			kn.CUD(deleteNCC, new List<SqlParameter> { new SqlParameter("@MaNCC", MaNCC) });

			// Hiển thị thông báo
			MessageBox.Show("Xóa nhà cung cấp thành công", "Thông báo");
		}

		public void suaDL(string MaNCC, string TenNCC, string DiaChi, string SDT)
		{
			string sql = "update NhaCungCap set TenNCC = @TenNCC, DiaChi = @DiaChi, SDT = @SDT where MaNCC = @MaNCC";
			List<SqlParameter> parameters = new List<SqlParameter>
			{
				new SqlParameter("@MaNCC", MaNCC),
				new SqlParameter("@TenNCC", TenNCC),
				new SqlParameter("@DiaChi", DiaChi),
				new SqlParameter("@SDT", SDT)
			};
			kn.CUD(sql, parameters);
			MessageBox.Show("Sửa thành công", "Thông báo");
		}
	}
}
