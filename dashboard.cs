using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FitnessApp.classes;

namespace FitnessApp
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
            lblDateTime.Text = DateTime.Now.ToString();
            cmbtrainingplanname.DataSource = training.getAllTrainingDetails();
            cmbtrainingplanname.DisplayMember = "trainingPlanName";
            cmbtrainingplanname.ValueMember = "trainingPlanID";
            cmbtrainingplanname.SelectedIndex = -1;
            dgvCustomerDeatils.DataSource = cc.customerList();
            dgvCustomerPlanDetails.DataSource = customertrainingplan.allTrainingPlans();
        }
        classes.CustomerClass cc=new classes.CustomerClass();
        classes.customertrainingplan customertrainingplan= new classes.customertrainingplan();
        classes.trainingplanclass training = new classes.trainingplanclass();

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserForm frm= new UserForm();
            frm.ShowDialog();
        }

        private void customerRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            customerform frm = new customerform();
            frm.ShowDialog();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void trainingPlanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TrainingPlanForm frm = new TrainingPlanForm();
            frm.ShowDialog();
        }

        private void customerTrainingPlanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            customerTrainingPlan cte = new customerTrainingPlan();
            cte.ShowDialog();
        }

        private void dgvCustomerDeatils_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvCustomerPlanDetails.DataSource = customertrainingplan.getTrainingPlanByCustomerId(int.Parse(dgvCustomerDeatils.SelectedRows[0].Cells["CustumerID"].Value.ToString()));

        }

        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {
            dgvCustomerDeatils.DataSource=cc.customerListByName(txtCustomerName.Text);
        }

        private void cmbtrainingplanname_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgvCustomerPlanDetails.DataSource = customertrainingplan.gettrainingDetailsByName(cmbtrainingplanname.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            
            }
        }
    }
}
