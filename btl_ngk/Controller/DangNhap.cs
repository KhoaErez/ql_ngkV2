using btl_ngk.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btl_ngk.Controller
{
	public class DangNhap
	{
		KetNoi kn;
		public DangNhap() 
		{
			kn = new KetNoi();
		}

		public bool check(string user, string pass)
		{
			string sql = "select count(*) from Users where TenDN = @user and MatKhau = @pass";
			List<SqlParameter> parameters = new List<SqlParameter>();
			parameters.Add(new SqlParameter("@user", user));
			parameters.Add(new SqlParameter("@pass", pass));
			if(kn.kiemTraMaTrung(sql, parameters))
			{
				Form Main = new frmMain();
				Main.ShowDialog();
				return true;
			}	
			else
			{
				MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu", "Thông báo");
				return false;
			}	
		}
	}
}
