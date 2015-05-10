using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using Database;
using System.Data.Entity;
using PodrozeSluzbowe.Supervisor;

namespace PodrozeSluzbowe
{
    public partial class PanelAdministracyjny : Form
    {
        public PanelAdministracyjny()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Login = ""; string Password = ""; string FirstName = ""; string SurName = ""; int DepartmentId = 1;
            try
            {
                Login = txtLogin.Text;
                Password = txtPassword.Text;
                FirstName = txtLogin.Text;
                SurName = txtNazwisko.Text;
                DepartmentId =Convert.ToInt16 ( txtDział.Text);
            }
            catch
            {

            }


            SuperVisor superV = new SuperVisor();
            superV.AddUser(Login, Password, FirstName, SurName, DepartmentId);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
          

        }
    }
}
