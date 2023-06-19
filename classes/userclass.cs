using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Runtime.Remoting.Messaging;

namespace FitnessApp.classes
{
	public class userclass
	{
		SqlConnection conn = new SqlConnection(connectionclass.connectionstring);
		public bool manageusers(int userID, string userName, string password, int Mode)
		{
			bool result = false;
			try
			{
				String txtsql = "";
				if (Mode == 1)
				{
					txtsql = @" insert into userTable(userName,password)
                           values (@userName,@password)";
				}
				if (Mode == 2)
				{
					txtsql = @"update userTable set userName=@userName,password=@password
                              where userID=@userID";
				}
				if (Mode == 3)
				{
					txtsql = @"Delete from userTable where userID=@userID";
				}
				SqlCommand cmd = new SqlCommand(txtsql, conn);
				cmd.CommandType = CommandType.Text;
				cmd.Parameters.AddWithValue(@"userID", userID);
				cmd.Parameters.AddWithValue(@"userName", userName);
				cmd.Parameters.AddWithValue(@"Password", password);
				conn.Open();
				int r = cmd.ExecuteNonQuery();
				if (r > 0)
					result = true;
				else
					result = false;
			}
			catch (Exception ex)
			{

				throw ex;
			}
			finally { conn.Close(); }
			return result;
		}
		public DataTable userList()
		{
			DataTable dt = new DataTable();
			try
			{
				SqlCommand cmd = new SqlCommand("select *from userTable", conn);
				conn.Open();
				SqlDataReader dr = cmd.ExecuteReader();
				dt.Load(dr);
				conn.Close();


			}
			catch (Exception ex)
			{

				throw ex;
			}
			finally { conn.Close(); }
			return dt;
		}
		public bool Login(string userName, String password)
		{
			try
			{
				bool rs = false;
				DataTable dt = new DataTable();
				SqlCommand cmd=new SqlCommand(@"Select * from userTable 
                                              where userName=@userName and password=@password", conn);
				cmd.CommandType=CommandType.Text;
				cmd.Parameters.AddWithValue("@userName", userName);
				cmd.Parameters.AddWithValue("@password", password);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                conn.Close();
				if (dt.Rows.Count > 0)
					rs = true;
				else rs = false;
				return rs;

			}
			catch (Exception ex)
			{

				throw ex;
			}
			finally { conn.Close(); }
		}
	}
}
