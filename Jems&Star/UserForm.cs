using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace Jems_Star
{
    public partial class UserForm : Form
    {
        public string code11 = "I";
        public UserForm()
        {
            InitializeComponent();
        }
        public string code22 = "Love";

        private void UserForm_Load(object sender, EventArgs e)
        {
            pnlLog.BorderStyle = BorderStyle.Fixed3D;
            pnlLog.BackColor = Color.FromArgb(200, 0, 0, 0);
            pnlLog.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public string code33 = "You";
        private void btnLogLogin_Click(object sender, EventArgs e)
        {
            String userName = txtLogUser.Text;
            String code = txtLogPassword.Text;
            String keyCode = "1234"; //code11 + code22 + code33;   // 

            if ( userName == "dhanushka" && code == keyCode)
            {
                logFile();
                this.Hide();
            }
            else if(userName == "hashini" && code == keyCode)
            {
                logFile();
                this.Hide();
            }
            else if (userName == "tharushi" && code == keyCode)
            {
                logFile();
                this.Hide();
            }
            else if (userName == "dhananjali" && code == keyCode)
            {
                logFile();
                this.Hide();
            }
            else
            {
                MessageBox.Show("This Password or User Name is Incorrect", "Alart Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
              
                txtLogPassword.Clear();
                txtLogUser.Clear();
                txtLogUser.Focus();
                pnlLog.BackColor = Color.FromArgb(100, 80, 0, 0);
            }
        }
        public static void logFile()
        {
            SelectForm menuForm = new SelectForm();
            menuForm.Show();
            
        }
    }
}
