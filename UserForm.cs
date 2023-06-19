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
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
            dgvUser.DataSource = uc.userList();

        }
        int userID;

        private void btnClose_Click(object sender, EventArgs e)
        {
             Close();
        }
        classes.userclass uc=new classes.userclass(); 

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            if (txtuserName.Text == "" || txtpassword.Text == "")
            {
                MessageBox.Show("The fields Cannot be Blank!");
            }
            else if (txtpassword.Text != txtconfirmpassword.Text)
            {
                MessageBox.Show("Passwords donot match");
                txtpassword.Clear();
                txtconfirmpassword.Clear();
                txtuserName.Focus();


            }
            else
            {
                createuser();

            }
}

        public void createuser()
        {
            try
            {
                bool r = uc.manageusers(0, txtuserName.Text, txtpassword.Text, 1);
                if (r == true)
                {
                    MessageBox.Show("User SuccessFully Created");
                    dgvUser.DataSource = uc.userList();

                }
                else
                {
                    MessageBox.Show("error in performing the required operation");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            userID = int.Parse(dgvUser.SelectedRows[0].Cells["userID"].Value.ToString());
            txtuserName.Text = (dgvUser.SelectedRows[0].Cells["userName"].Value.ToString());
            txtpassword.Text= (dgvUser.SelectedRows[0].Cells["password"].Value.ToString());
            txtconfirmpassword.Text= (dgvUser.SelectedRows[0].Cells["password"].Value.ToString());
             
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            if (txtuserName.Text == "" || txtpassword.Text == "")
            {
                MessageBox.Show("The fields Cannot be Blank!");
            }
            else if (txtpassword.Text != txtconfirmpassword.Text)
            {
                MessageBox.Show("Passwords donot match");
                txtpassword.Clear();
                txtconfirmpassword.Clear();
                txtuserName.Focus();


            }
            else
            {
                updateuser();

            }
        }
        public void updateuser()
        {
            try
            {
                bool r = uc.manageusers(userID, txtuserName.Text, txtpassword.Text, 2);
                if (r == true)
                {
                    MessageBox.Show("User SuccessFully Updated");
                    dgvUser.DataSource = uc.userList();

                }
                else
                {
                    MessageBox.Show("error in performing the required operation");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            try
            {
                bool r = uc.manageusers(userID, txtuserName.Text, txtpassword.Text, 3);
                if (r == true)
                {
                    MessageBox.Show("User SuccessFully Deleted ");
                    dgvUser.DataSource = uc.userList();

                }
                else
                {
                    MessageBox.Show("error in performing the required operation");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
