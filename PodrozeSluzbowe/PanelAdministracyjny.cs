﻿using System;
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
            /*
            using (PodrozeEntities context = new PodrozeEntities())
            {
                int Id = 1;
               Users user = context.Users.Where(c => c.Id == Id).First();
                user.Active = false;
                context.SaveChanges();
            }
            */
        }

        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            string Brand=""; string Model=""; string RegistrationNumber=""; short NumberOfSeats=1;
            //string registrationNumber;
            try
            {

                Brand = txtBrand.Text;
                Model = txtModel.Text;
                RegistrationNumber = txtRegistrationNumber.Text;
                NumberOfSeats = Convert.ToInt16(txtNumberOfSeats.Text);


                //    registrationNumber = txtRegistrationNumber.Text;
               

            }
            catch
            {

            }
            SuperVisor superV = new SuperVisor();

            superV.AddCar(Brand, Model, RegistrationNumber, NumberOfSeats);

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            List<string> lista = new List<string>();
           
          //  dataGridViewCars.DataSource = BusinessClasses.MenageContext.GetCars(lista);
            dataGridViewCars.DataSource = BusinessClasses.MenageContext.GetCars(lista);

        }
    }
}
