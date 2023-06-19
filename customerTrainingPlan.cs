using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessApp
{
    public partial class customerTrainingPlan : Form
    {
        public customerTrainingPlan()
        {
            InitializeComponent();
            dgvcustomerplan.DataSource = cc.customerList();
            cmbplanname.DataSource = tpc.getAllTrainingDetails();
            cmbplanname.DisplayMember = "trainingPlanName";
            cmbplanname.ValueMember = "trainingPlanID";
            cmbplanname.SelectedIndex = -1;
            dgvselectedplandetails.DataSource = ctp.allTrainingPlans();
        }

        classes.CustomerClass cc = new classes.CustomerClass();
        classes.trainingplanclass tpc = new classes.trainingplanclass();
        classes.customertrainingplan ctp = new classes.customertrainingplan();
        int Id = 0;

        private void txtcustomerName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dgvcustomerplan.DataSource = cc.customerListByName(txtcustomerName.Text);
            }
            catch (Exception)
            {

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnaddplan_Click(object sender, EventArgs e)
        {
            try
            {
                bool rs = ctp.manageCustomerTrainingPlan(Id,
                    int.Parse(lblCustomerId.Text),
                    int.Parse(cmbplanname.SelectedValue.ToString()),
                    int.Parse(txtunit.Text), txtremarks.Text, 1);
                if (rs == true)
                {
                    dgvselectedplandetails.DataSource = ctp.getTrainingPlanByCustomerId(int.Parse(lblCustomerId.Text));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvcustomerplan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcustomerName.Text = dgvcustomerplan.SelectedRows[0].Cells["CustomerName"].Value.ToString();
            lblCustomerId.Text = dgvcustomerplan.SelectedRows[0].Cells["CustumerID"].Value.ToString();
            dgvselectedplandetails.DataSource = ctp.getTrainingPlanByCustomerId(int.Parse(lblCustomerId.Text));
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the selected plan ID
                int planId = GetSelectedPlanId();

                if (planId != -1)
                {
                    // Call the manageCustomerTrainingPlan method with mode = 2 for editing
                    bool rs = ctp.manageCustomerTrainingPlan(planId, int.Parse(lblCustomerId.Text),
                        int.Parse(cmbplanname.SelectedValue.ToString()), int.Parse(txtunit.Text), txtremarks.Text, 2);

                    if (rs)
                    {
                        dgvselectedplandetails.DataSource = ctp.getTrainingPlanByCustomerId(int.Parse(lblCustomerId.Text));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the selected plan ID
                int planId = GetSelectedPlanId();

                if (planId != -1)
                {
                    // Confirm deletion with the user
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this training plan?", "Confirmation", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        // Call the manageCustomerTrainingPlan method with mode = 3 for deletion
                        bool rs = ctp.manageCustomerTrainingPlan(planId, int.Parse(lblCustomerId.Text),
                            0, 0, "", 3);

                        if (rs)
                        {
                            dgvselectedplandetails.DataSource = ctp.getTrainingPlanByCustomerId(int.Parse(lblCustomerId.Text));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private int GetSelectedPlanId()
        {
            if (dgvselectedplandetails.SelectedRows.Count > 0)
            {
                int planId = Convert.ToInt32(dgvselectedplandetails.SelectedRows[0].Cells["Id"].Value);
                return planId;
            }
            return -1;
        }


    }
}
