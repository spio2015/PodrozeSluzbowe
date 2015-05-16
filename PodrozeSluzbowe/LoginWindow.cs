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
        public Database.Users User = new Database.Users();

        public LoginWindow()
        {
            InitializeComponent();
            cmbLogin.DataSource = BusinessClasses.MenageContext.GetUsers();
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
            Database.Users user = BusinessClasses.MenageContext.Login(cmbLogin.SelectedValue.ToString(), tbxPassword.Text);
            if (user.Id > 0)
            {
                User = user;
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
