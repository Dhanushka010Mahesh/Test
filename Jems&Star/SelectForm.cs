using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jems_Star
{
    public partial class SelectForm : Form
    {
        int mm;
        public String code44;
        public SelectForm()
        {
            InitializeComponent();
        }

        private void btnSelectStrat_Click(object sender, EventArgs e)
        {
            Form1 gameForm= new Form1();
            gameForm.Show();
            this.Close();
        }

        private void btnMenuExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void SelectForm_Load(object sender, EventArgs e)
        {
            pnlSelect.BackColor = Color.FromArgb(160, 0, 0, 0);
            /*  UserForm userForm = new UserForm();
              String x= userForm.code11;
              String y = userForm.code22;
              String z = userForm.code33;

              code44 = x + y + z;
              code44 retrun;
            */
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You can't Edit Game Setting");
        }
    }
}
