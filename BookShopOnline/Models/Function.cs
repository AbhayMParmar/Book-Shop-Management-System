using System;
using System.Data;
using System.Data.SqlClient;

namespace BookShopOnline.Models
{
	public class Function
	{
		private SqlConnection Con;
		private SqlCommand cmd;
		private DataTable dt;
		private SqlDataAdapter sda;
		private string ConStr;
		public Function()
		{
			ConStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\OneDrive\Dokumen\Bookshop25ASPDB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False";
			Con= new SqlConnection(ConStr);
			cmd = new SqlCommand();
			cmd.Connection = Con;
        }
		public DataTable GetData(String Query)
		{
			dt= new DataTable();
			sda = new SqlDataAdapter(Query,ConStr);
			sda.Fill(dt);
			return dt;
		}
		public int SetData(string Query)
		{
			int cnt = 0;
			if (Con.State == ConnectionState.Closed)
			{
				Con.Open();
			}
			cmd.CommandText = Query;
			cnt = cmd.ExecuteNonQuery();
			Con.Close();
			return cnt;
		}
	}
}