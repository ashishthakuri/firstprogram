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
    public partial class TrainingPlanForm : Form
    {
        private classes.trainingplanclass tpc;
        private int trainingPlanID;

        public TrainingPlanForm()
        {
            InitializeComponent();
            tpc = new classes.trainingplanclass();
            dataGridView1.DataSource = tpc.getAllTrainingDetails();
            dataGridView1.CellClick += dataGridView1_CellClick;

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btncreatetrainingplan_Click(object sender, EventArgs e)
        {
            try
            {
                bool rs = tpc.manageTrainingplans(trainingPlanID,
                    txttrainingplanname.Text,
                    cmbunit.Text,
                    Double.Parse(txtrate.Text),
                    txtremarks.Text, 1);
                if (rs == true)
                {
                    MessageBox.Show("Training Plan successfully created: Time to build Muscle");
                    RefreshTrainingPlanList();
                }
                else
                    MessageBox.Show("Oops!!! Error in performing the operation");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RefreshTrainingPlanList()
        {
            dataGridView1.DataSource = tpc.getAllTrainingDetails();
        }

        private void btnedittrainingplan_Click(object sender, EventArgs e)
        {
            try
            {
                bool rs = tpc.manageTrainingplans(trainingPlanID,
                    txttrainingplanname.Text,
                    cmbunit.Text,
                    Double.Parse(txtrate.Text),
                    txtremarks.Text, 2);
                if (rs == true)
                {
                    MessageBox.Show("Training Plan successfully updated");
                    RefreshTrainingPlanList();
                }
                else
                    MessageBox.Show("Oops!!! Error in performing the operation");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btndeletetrainingplan_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this training plan?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    bool rs = tpc.manageTrainingplans(trainingPlanID, "", "", 0, "", 3);
                    if (rs == true)
                    {
                        MessageBox.Show("Training Plan successfully deleted");
                        RefreshTrainingPlanList();
                        ClearFormFields();
                    }
                    else
                        MessageBox.Show("Oops!!! Error in performing the operation");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ClearFormFields()
        {
            trainingPlanID = 0;
            txttrainingplanname.Text = "";
            cmbunit.SelectedIndex = -1;
            txtrate.Text = "";
            txtremarks.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                trainingPlanID = Convert.ToInt32(selectedRow.Cells["TrainingPlanID"].Value);
                txttrainingplanname.Text = selectedRow.Cells["TrainingPlanName"].Value.ToString();
                cmbunit.Text = selectedRow.Cells["Unit"].Value.ToString();
                txtrate.Text = selectedRow.Cells["Rate"].Value.ToString();
                txtremarks.Text = selectedRow.Cells["Remarks"].Value.ToString();
            }
        }
    }
}
