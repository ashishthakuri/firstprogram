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
    public partial class customerform : Form
    {
        public customerform()
        {
            InitializeComponent();
            dgvCustomerDetails.DataSource = cc.customerList();
        }
        classes.CustomerClass cc = new classes.CustomerClass();

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                bool result = cc.manageCustomers(CustumerID,
                    txtCustomerName.Text,
                    DateTime.Parse(dtpDOB.Text),
                    txtaddress.Text,
                   txtContactNumber.Text,
                   txtEmail.Text,
                   int.Parse(txtCurrentWeight.Text),
                   int.Parse(txtTargetWeight.Text),
                   1);
                if (result == true)
                {
                    MessageBox.Show("Customer Successfully added to the List");

                    dgvCustomerDetails.DataSource = cc.customerList();
                }
                else
                {
                    MessageBox.Show("Error in performing the required operation!!!");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        int CustumerID = 0;

        private void dgvCustomerDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CustumerID = int.Parse(dgvCustomerDetails.SelectedRows[0].Cells["CustumerID"].Value.ToString());
            txtCustomerName.Text = dgvCustomerDetails.SelectedRows[0].Cells["CustomerName"].Value.ToString();
            dtpDOB.Text = dgvCustomerDetails.SelectedRows[0].Cells["DOB"].Value.ToString();
            txtaddress.Text = dgvCustomerDetails.SelectedRows[0].Cells["address"].Value.ToString();
            txtContactNumber.Text = dgvCustomerDetails.SelectedRows[0].Cells["contact"].ToString();
            txtEmail.Text = dgvCustomerDetails.SelectedRows[0].Cells["email"].ToString();
            txtCurrentWeight.Text = dgvCustomerDetails.SelectedRows[0].Cells["CurrentWeight"].ToString();
            txtTargetWeight.Text = dgvCustomerDetails.SelectedRows[0].Cells["TargetWeight"].ToString();

        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                bool result = cc.manageCustomers(CustumerID,
                    txtCustomerName.Text,
                    DateTime.Parse(dtpDOB.Text),
                    txtaddress.Text,
                   txtContactNumber.Text,
                   txtEmail.Text,
                   int.Parse(txtCurrentWeight.Text),
                   int.Parse(txtTargetWeight.Text),
                   2);
                if (result == true)
                {
                    MessageBox.Show("Customer Successfully edited from the List");

                    dgvCustomerDetails.DataSource = cc.customerList();
                }
                else
                {
                    MessageBox.Show("Error in performing the required operation!!!");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                bool result = cc.manageCustomers(CustumerID,
                    txtCustomerName.Text,
                    DateTime.Parse(dtpDOB.Text),
                    txtaddress.Text,
                   txtContactNumber.Text,
                   txtEmail.Text,
                   int.Parse(txtCurrentWeight.Text),
                   int.Parse(txtTargetWeight.Text),
                   3);
                if (result == true)
                {
                    MessageBox.Show("Customer Successfully Deleted from the List");

                    dgvCustomerDetails.DataSource = cc.customerList();
                }
                else
                {
                    MessageBox.Show("Error in performing the required operation!!!");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
