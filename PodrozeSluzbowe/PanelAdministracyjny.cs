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
          //  removeUser.Visible = false;
          //  button1.Visible = false;
          //  dataGridViewCars.Visible = false;
        //    dataGridViewUsers.Visible = false;
            refreshCarList();
            refreshUserList();
            LoadDepartmentsToCombox();
        }


        private void LoadDepartmentsToCombox()
        {
            SuperVisorUsers superV = new SuperVisorUsers();
            cmbBoxUsersDepartment.DataSource = superV.getDepartments();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Login = ""; string Password = ""; string FirstName = ""; string SurName = ""; int DepartmentId = 1; string DepartmentName = ""; string password2 = "";
            try
            {
                Login = txtLogin.Text;
                Password = txtPassword.Text;
                FirstName = txtLogin.Text;
                SurName = txtNazwisko.Text;
                password2 = txtPassword2.Text;
             //   DepartmentId =Convert.ToInt16 ( txtDział.Text);
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
           // int id;
            
           
            
         
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
            }
            catch
            {
            }
            SuperVisorCar superV = new SuperVisorCar();
            superV.AddCar(Brand, Model, RegistrationNumber, NumberOfSeats);                        
            refreshCarList();  
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

        }

        private void button1_Click_3(object sender, EventArgs e)
        {
           
        }
    }
}
