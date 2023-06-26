using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
namespace CCX4_framwork4_8
{
    public partial class login : MaterialForm
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string username = "admin";
            string password = "123";
            if(username.Equals(txtuser.Text) && password.Equals(txtpassword.Text)) {

                this.Hide();
                hello fh = new hello();

                fh.ShowDialog();
                this.Close();
            }
            else if (username.Equals(txtuser.Text)){

                MessageBox.Show("password is incorrect","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning); 

            }else if (password.Equals(txtpassword.Text))
            {

                MessageBox.Show("Username is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("username and password are incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
