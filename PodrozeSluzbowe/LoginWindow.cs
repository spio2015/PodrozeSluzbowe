using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PodrozeSluzbowe;

namespace PodrozeSluzbowe
{
    public partial class LoginWindow : Form
    {
        private int counter = 1;

        public LoginWindow()
        {
            InitializeComponent();
            Supervisor.SuperVisorUsers superV = new Supervisor.SuperVisorUsers();
            cmbLogin.DataSource = superV.getUsersLogins();
            this.DialogResult = System.Windows.Forms.DialogResult.Abort;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Login();
            }
        }
     
        private void Login()
        {
            if (BusinessClasses.MenageContext.Login(cmbLogin.SelectedValue.ToString(), tbxPassword.Text))
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                counter++;
                if (counter > 3)
                {
                    MessageBox.Show("Trzy błedne logowania. Aplikacja zostanie zamknięta");
                    this.Close();
                }
                tbxPassword.Text = "";
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }
    }
}
