using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Drawing;
using System.Data;

namespace FitnessApp.classes
{
    public class customertrainingplan
    {
        SqlConnection conn = new SqlConnection(connectionclass.connectionstring);
        public bool manageCustomerTrainingPlan(int Id,
            int CustumerID,
            int trainingPlanID,
            int Units,
            String remarks,
            int mode)
        {
            try
            {
                bool result = false;
                string txtsql = "";
                if (mode == 1)
                {
                    txtsql = @"insert into CustomerTrainingPlanTable(CustumerID,trainingPlanID,Units,remarks) values(@CustumerID,@trainingPlanID,@Units,@remarks)";

                }
                if (mode == 2)
                {
                    txtsql = @"Update CustomerTrainingPlanTable set CustumerID=@CustumerID,trainingPlanID=@trainingPlanID,Units=@Units,remarks=@remarks where Id=@Id";

                }
                if (mode == 3)
                {
                    txtsql = @"delete from CustomerTrainingPlanTable where Id=@Id";
                }
                SqlCommand cmd=new SqlCommand(txtsql, conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue(@"Id", Id); 
                cmd.Parameters.AddWithValue(@"CustumerID", CustumerID);
                cmd.Parameters.AddWithValue(@"trainingPlanID", trainingPlanID);
                cmd.Parameters.AddWithValue(@"Units", Units);
                cmd.Parameters.AddWithValue(@"remarks", remarks);
                conn.Open();
                int r = cmd.ExecuteNonQuery();
                conn.Close();
                if (r > 0)
                    result = true;
                else
                    result = false;
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { conn.Close(); }    
        }
        public DataTable allTrainingPlans()
        {
            try
            {
                DataTable dt=new DataTable();
                SqlCommand cmd = new SqlCommand(@"select Id,CustomerName,
                 trainingPlanName,ct.Units,rate,Amount=ct.Units*rate from CustomerTrainingPlanTable ct,
                 trainingPlanTable t,customerTable c where ct.trainingPlanID=t.trainingPlanID and ct.CustumerID=c.CustumerID", conn);
                conn.Open();
                SqlDataReader dr=cmd.ExecuteReader();
                dt.Load(dr);
                conn.Close();
                return dt;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { conn.Close(); }
        }

        public DataTable getTrainingPlanByCustomerId (int CustumerID)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand(@"select Id,CustomerName,
                 trainingPlanName,ct.Units,rate,Amount=ct.Units*rate from CustomerTrainingPlanTable ct,
                 trainingPlanTable t,customerTable c where ct.trainingPlanID=t.trainingPlanID and ct.CustumerID=c.CustumerID 
                 and c.CustumerID=@CustumerID",conn);
                cmd.Parameters.AddWithValue("@CustumerID", CustumerID);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                conn.Close();
                return dt;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { conn.Close(); }
        }
        public DataTable gettrainingDetailsByName(string trainingPlanName)
        {

            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand(@"select Id,CustomerName,
                 trainingPlanName,ct.Units,rate,Amount=ct.Units*rate from CustomerTrainingPlanTable ct,
                 trainingPlanTable t,customerTable c where ct.trainingPlanID=t.trainingPlanID and ct.CustumerID=c.CustumerID 
                 and ct.trainingPlanID=t.trainingPlanID and trainingPlanName=@trainingPlanName", conn);
                cmd.Parameters.AddWithValue("@trainingPlanName", trainingPlanName);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                conn.Close();
                return dt;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { conn.Close(); }
        }
       
    }
}
