using btl_ngk.Controller;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btl_ngk.Model
{
	public class KetNoi
	{
		SqlConnection conn;
		public void openConnection()
		{
			conn = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Application.StartupPath}\\BanHangNGK.mdf;Integrated Security=True;Connect Timeout=30");
			conn.Open();
		}

		public DataTable readData(string sql, List<SqlParameter> parameters = null)
		{
			DataTable dt = new DataTable();
			openConnection();
			try
			{
				using(SqlCommand cmd = new SqlCommand(sql,conn))
				{
					if (parameters != null)
					{
						cmd.Parameters.AddRange(parameters.ToArray());
					}
					using (SqlDataReader reader = cmd.ExecuteReader())
					{
						dt.Load(reader);
					}	
				}
			}catch(Exception ex)
			{
				MessageBox.Show("Lỗi " + ex.Message);
			}
			finally
			{
				closeConnection();
			}
			return dt;
		}
		public void CUD(string sql, List<SqlParameter> parameters = null)
		{
			try
			{
				openConnection();
				using (SqlCommand cmd = new SqlCommand(sql,conn))
				{
					if (parameters != null)
					{
						cmd.Parameters.AddRange(parameters.ToArray());
					}
					cmd.ExecuteNonQuery();
				}	
			}
			catch(Exception ex)
			{
				MessageBox.Show("Lỗi " + ex);
			}
			finally
			{
				closeConnection();
			}
		}
		public bool kiemTraMaTrung(string sql, List<SqlParameter> parameters)
		{
			try
			{
				openConnection();
				using (SqlCommand cmd = new SqlCommand(sql, conn))
				{
					if (parameters != null)
					{
						cmd.Parameters.AddRange(parameters.ToArray());
					}
					int result = Convert.ToInt32(cmd.ExecuteScalar());
					if (result > 0)
						return true;
					return false;
				}
			}
			catch(Exception e)
			{
				MessageBox.Show("Lỗi " + e.Message);
				return false;
			}
			finally
			{
				closeConnection();
			}
			
		}

		public string readText(string sql)
		{
			string ten = "";
			try
			{
				openConnection();
				using(SqlCommand cmd = new SqlCommand(sql, conn))
				{
					SqlDataReader reader = cmd.ExecuteReader();
					if(reader.HasRows) 
					{
						while (reader.Read())
						{
							ten = reader.GetValue(0).ToString();
						}
					}
					//else
					//{
					//	MessageBox.Show("Không có dữ liệu trả về.");
					//}
				}	
			}
			catch (Exception e)
			{
				MessageBox.Show("Lỗi " + e.Message);
			}
			finally
			{
				closeConnection();
			}
			return ten;
		}

		public void closeConnection()
		{
			conn.Close();
		}
	}
}
