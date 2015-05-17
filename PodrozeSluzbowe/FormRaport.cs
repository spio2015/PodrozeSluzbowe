using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PodrozeSluzbowe.Supervisor;

namespace PodrozeSluzbowe
{
    public partial class FormRaport : Form
    {
        public FormRaport()
        {
            InitializeComponent();
        }

        private void FormRaport_Load(object sender, EventArgs e)
        {
             
        }


        private void calendar_Click(TextBox textBox)
        {
            kalendarz _kalendarz = new kalendarz();
            _kalendarz.ShowDialog();
        
            if (_kalendarz.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                textBox.Text = _kalendarz.data;

            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            //sprawdzenie zakresu dat




            this.ViewerRaportTableAdapter.Fill(this.PodrozeDataSet.ViewerRaport);
            this.BusinessTripsTableAdapter.Fill(this.PodrozeDataSet.BusinessTrips);
          
            this.reportViewer1.RefreshReport();
        }




        private void textBoxDO_Click_1(object sender, EventArgs e)
        {
            calendar_Click(textBoxDO);
        }

        private void textBoxOD_Click(object sender, EventArgs e)
        {
            calendar_Click(textBoxOD);
        }
    }
}
