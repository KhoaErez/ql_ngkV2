using btl_ngk.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btl_ngk.Controller
{
	internal class NhanVien
	{
		KetNoi kn;

		public NhanVien()
		{
			kn = new KetNoi();
		}

		public DataTable readDL()
		{
			string sql = "SELECT * from USERS";
			return kn.readData(sql);
		}
	}
}
