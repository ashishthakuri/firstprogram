using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessApp
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        classes.userclass uc=new classes.userclass(); 

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to exit",
                "Confirm Exit",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                Close();
            }
            else
                return;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                bool rs =uc.Login(txtUserName.Text,txtpassword.Text);
                if (rs == true)
                {
                    dashboard frm = new dashboard();
                    frm.Show();
                }
                else
                {
                    txtUserName.Clear();
                    txtpassword.Clear();
                    txtUserName.Focus();
                    MessageBox.Show("Invalid username or password");

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
