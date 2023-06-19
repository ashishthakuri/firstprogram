using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp.classes
{
    public class trainingplanclass
    {
        public bool manageTrainingplans(int trainingPlanID, string trainingPlanName,
            string unit, double rate, string remarks, int mode)
        {
            try
            {
                bool result = false;
                string txtsql = "";
                using (SqlConnection conn = new SqlConnection(connectionclass.connectionstring))
                {
                    if (mode == 1)
                        txtsql = @"INSERT INTO trainingPlanTable (trainingPlanName, unit, rate, remarks)
                                   VALUES (@trainingPlanName, @unit, @rate, @remarks)";
                    else if (mode == 2)
                        txtsql = @"UPDATE trainingPlanTable
                                   SET trainingPlanName = @trainingPlanName, unit = @unit, rate = @rate, remarks = @remarks
                                   WHERE trainingPlanID = @trainingPlanID";
                    else if (mode == 3)
                        txtsql = @"DELETE FROM trainingPlanTable WHERE trainingPlanID = @trainingPlanID";

                    using (SqlCommand cmd = new SqlCommand(txtsql, conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@trainingPlanID", trainingPlanID);
                        cmd.Parameters.AddWithValue("@trainingPlanName", trainingPlanName);
                        cmd.Parameters.AddWithValue("@unit", unit);
                        cmd.Parameters.AddWithValue("@rate", rate);
                        cmd.Parameters.AddWithValue("@remarks", remarks);

                        conn.Open();
                        int rs = cmd.ExecuteNonQuery();

                        if (rs > 0)
                            result = true;
                    }
                }

                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable getAllTrainingDetails()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionclass.connectionstring))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM trainingPlanTable", conn);
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    dt.Load(dr);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return dt;
        }
    }
}
