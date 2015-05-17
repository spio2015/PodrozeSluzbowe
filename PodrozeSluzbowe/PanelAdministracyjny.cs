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
   
            refreshCarList();
            refreshUserList();
            LoadDepartmentsToCombox();
            textboxCarErrors();
            textboxUserErrors();
            btnAddCar.Enabled = false;
            btnAddUser.Enabled = false;
        }


        private void LoadDepartmentsToCombox()
        {
            SuperVisorUsers superV = new SuperVisorUsers();
            cmbBoxUsersDepartment.DataSource = superV.getDepartments();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Login = ""; string Password = ""; string FirstName = ""; string SurName = ""; string DepartmentName = ""; string password2 = "";
            try
            {
                Login = txtLogin.Text;
                Password = txtPassword.Text;
                FirstName = txtLogin.Text;
                SurName = txtNazwisko.Text;
                password2 = txtPassword2.Text;
      
                DepartmentName = cmbBoxUsersDepartment.SelectedItem.ToString();            
            }
            catch
            {

            }
            SuperVisorUsers superV = new SuperVisorUsers();
            superV.AddUser(Login, Password,password2, FirstName, SurName, DepartmentName);
            refreshUserList();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
         
            using (PodrozeEntities context = new PodrozeEntities())
            {
                if(dataGridViewUsers.SelectedRows.Count>0)
                {
                Users user = (Users)dataGridViewUsers.SelectedRows[0].DataBoundItem;
                SuperVisorUsers superV = new SuperVisorUsers();
                superV.deleteUser(user);             
                }
                else
                {
                    MessageBox.Show("Zaznacz wiersz na liście poniżej w celu usunięcia użytkownika");
                }
           }
            refreshUserList();
        }
        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string Brand=""; string Model=""; string RegistrationNumber=""; short NumberOfSeats=1;
            try
            {
                Brand = txtBrand.Text;
                Model = txtModel.Text;
                RegistrationNumber = txtRegistrationNumber.Text;
                NumberOfSeats = Convert.ToInt16(txtNumberOfSeats.Text);
                SuperVisorCar superV = new SuperVisorCar();
                superV.AddCar(Brand, Model, RegistrationNumber, NumberOfSeats);
                refreshCarList();  
            }
             catch (FormatException ee)

             {
             //    ee.ToString();
    
              //  MessageBox.Show("błędne dane");

            
                 /*
                var boxes = gbAddCar.Controls.OfType<TextBox>();
                foreach (var box in boxes)
                {
                    errorProvAdm.SetError(box, "błąd danych");
                }
                 */
                MessageBox.Show(ee.Message);

             }
            catch
            { 
            }   
        }





        public void refreshCarList()
        {
            List<Cars> cars = new List<Cars>();
            PodrozeEntities context1 = new PodrozeEntities();
            cars = context1.Cars.Where(c => c.Active == true).ToList();
            dataGridViewCars.DataSource = cars;
            dataGridViewCars.Columns[5].Visible = false;
            dataGridViewCars.Columns[6].Visible = false;
        }
        public void refreshUserList()
        {
            List<Users> user = new List<Users>();
            PodrozeEntities context1 = new PodrozeEntities();
            user = context1.Users.Where(c => c.Active == true).ToList();            
            dataGridViewUsers.DataSource = user;
            dataGridViewUsers.Columns[5].Visible = false;
            dataGridViewUsers.Columns[6].Visible = false;
            dataGridViewUsers.Columns[7].Visible = false;
            dataGridViewUsers.Columns[8].Visible = false;
        }
        private void button1_Click_2(object sender, EventArgs e)
        {
            if (dataGridViewCars.SelectedRows.Count > 0)
            {
                    Cars cars = (Cars)dataGridViewCars.SelectedRows[0].DataBoundItem;
                    SuperVisorCar sVisor = new SuperVisorCar();
                    sVisor.deleteCar(cars);                
            }
            else
            {
                MessageBox.Show("Zaznacz wiersz na liście poniżej w celu usunięcia samochodu");
            }
            refreshCarList();         
        }
        private void txtRegistrationNumber_TextChanged(object sender, EventArgs e)
        {
            textboxCarErrors();
        }
        private void button1_Click_3(object sender, EventArgs e)
        {
           
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textboxCarErrors();
        }
        private void txtNumberOfSeats_TextChanged(object sender, EventArgs e)
        {
            textboxCarErrors();
        }
        void textboxCarErrors()
        {
            var boxes = gbAddCar.Controls.OfType<TextBox>();
            int numberOfError;
            int numberOfControls;
            numberOfControls = gbAddCar.Controls.OfType<TextBox>().Count();
            numberOfError = 0;
            bool isOnError = false;
            foreach (var box in boxes)
            {
                isOnError = false;

                if (string.IsNullOrWhiteSpace(box.Text))
                {
                    errorProvAdm.SetError(box, "Proszę uzupełnić pola");
                    isOnError = true;
                }
                else
                {
                    errorProvAdm.SetError(box,"");
                }
                if (isOnError == true) numberOfError++;
            }
            if (numberOfError == 0) { btnAddCar.Enabled = true; } else { btnAddCar.Enabled = false; }
        }
        void textboxUserErrors()
        {
            var boxes = gbAddUser.Controls.OfType<TextBox>();
            int numberOfError;
            int numberOfControls;
            numberOfControls = gbAddUser.Controls.OfType<TextBox>().Count();
            numberOfError = 0;
            bool isOnError = false;
            foreach (var box in boxes)
            {
                isOnError = false;
                if (string.IsNullOrWhiteSpace(box.Text))
                {
                    errorProvAdm.SetError(box, "Proszę uzupełnić pola");
                    isOnError = true;
                }
                else
                {
                    errorProvAdm.SetError(box, "");

                }
                if (isOnError == true) numberOfError++;
            }
            if (numberOfError == 0) { btnAddUser.Enabled = true; } else { btnAddUser.Enabled = false; }
        }
        private void txtBrand_TextChanged(object sender, EventArgs e)
        {
            textboxCarErrors();
        }
        private void txtModel_TextChanged(object sender, EventArgs e)
        {
            textboxCarErrors();
        }
        private void txtLogin_TextChanged(object sender, EventArgs e)
        {
            textboxUserErrors();
        }
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            textboxUserErrors();
        }
        private void txtPassword2_TextChanged(object sender, EventArgs e)
        {
            textboxUserErrors();
        }
        private void txtImie_TextChanged(object sender, EventArgs e)
        {
            textboxUserErrors();
        }
        private void txtNazwisko_TextChanged(object sender, EventArgs e)
        {
            textboxUserErrors();
        }
    }
}
