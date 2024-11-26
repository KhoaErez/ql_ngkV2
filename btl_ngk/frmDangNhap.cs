using btl_ngk.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btl_ngk
{
	public partial class frmDangNhap : Form
	{
		string tendn;
		
		DangNhap dn = new DangNhap();
		public frmDangNhap()
		{
			InitializeComponent();
			txtMatKhau.UseSystemPasswordChar = true;
		}

		private void frmDangNhap_Load(object sender, EventArgs e)
		{
		}

		private void btnDangNhap_Click(object sender, EventArgs e)
		{
			//if(dn.check(txtTaiKhoan.Text, txtMatKhau.Text))
			//{
			//	tendn = txtTaiKhoan.Text;
			//}	
			dn.check(txtTaiKhoan.Text, txtMatKhau.Text);
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			txtMatKhau.UseSystemPasswordChar = !checkBox1.Checked;
		}

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		public static string GetCurrentUsername()
		{
			return "khoa";
		}
	}
}
