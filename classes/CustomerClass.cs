using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace FitnessApp.classes
{
    public class CustomerClass
    {
        SqlConnection conn = new SqlConnection(connectionclass.connectionstring);
        public bool manageCustomers(int CustumerID,
            string CustomerName,
            DateTime DOB,
            String address,
            String contact,
            String email,
            int CurrentWeight,
            int TargetWeight,
            int mode)
        {
            bool result = false;
            try
            {
                String txtSql = "";
                if (mode == 1)
                {
                    txtSql = @"insert into customerTable 
                               (CustomerName,DOB,address,contact,email,CurrentWeight,TargetWeight) 
                    values
                    (@CustomerName, @DOB, @address, @contact, @email, @CurrentWeight, @TargetWeight)";
                }
                if (mode == 2)
                    txtSql = @"update customerTable set CustomerName=@CustomerName, DOB=@DOB, address=@address, 
                         contact=@contact, email=@email, CurrentWeight=@CurrentWeight, TargetWeight=@TargetWeight where
                            CustumerID=@CustumerID";
                if (mode == 3)
                    txtSql = @"Delete from customerTable where CustumerID = @CustumerID";

                SqlCommand cmd = new SqlCommand(txtSql, conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@CustumerID", CustumerID);
                cmd.Parameters.AddWithValue("@CustomerName", CustomerName);
                cmd.Parameters.AddWithValue("@DOB", DOB);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@contact", contact);
                cmd.Parameters.AddWithValue("@CurrentWeight", CurrentWeight);
                cmd.Parameters.AddWithValue("@TargetWeight", TargetWeight);
                conn.Open();
                int r = cmd.ExecuteNonQuery();
                conn.Close();
                if (r > 0)
                    result = true;
                else result = false;


            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally { conn.Close(); }
            return result;
        }
        public DataTable customerList()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand("select * from customerTable", conn);
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
        public DataTable customerListByName(string customerName)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand(@"select * from customerTable where CustomerName like '%' + @customerName + '%' ", conn);
                cmd.Parameters.AddWithValue("@customerName", customerName);
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

    }
}
