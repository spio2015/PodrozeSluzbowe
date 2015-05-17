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
                String dataOD = _kalendarz.data;
                textBoxDO.Enabled = true;
                textBox.Text = _kalendarz.data;

            }
            else
                textBoxDO.Enabled = false;
        }


        private void calendar_Click(TextBox textBox, DateTime MinDate)
        {
            kalendarz _kalendarz = new kalendarz(MinDate);
            _kalendarz.ShowDialog();
            if (_kalendarz.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                textBox.Text = _kalendarz.data;
                String dataDO = _kalendarz.data;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //sprawdzenie zakresu dat
            if (textBoxOD.Text.Length > 0 && textBoxDO.Text.Length > 0)
                {
                    String s = "SELECT        c.Brand, c.Model, d.Address, u.Login, bt.DepartureDate, bt.ArrivalDate "
                                +" FROM            BusinessTrips AS bt INNER JOIN "
                         +" Cars AS c ON bt.CarId = c.Id INNER JOIN "
                         +" Destinations AS d ON bt.DestinationId = d.Id INNER JOIN "
                         +" Users AS u ON bt.UserId = u.Id ";

                    //this.PodrozeDataSet.ViewerRaport.Select(s);

                   DateTime DateOd = DateTime.ParseExact(textBoxOD.Text, "yyyy-MM-dd", null);
                   DateTime DateDo = DateTime.ParseExact(textBoxDO.Text, "yyyy-MM-dd", null);

                   this.ViewerRaportTableAdapter.ClearBeforeFill = true;
                   this.ViewerRaportTableAdapter.GetDataByOdjazd(DateOd,DateDo);
                   this.ViewerRaportTableAdapter.FillBy1(this.PodrozeDataSet.ViewerRaport, DateOd, DateDo);

               // this.ViewerRaportTableAdapter.Fill(this.ViewerRaportTableAdapter.GetDataByOdjazd(DateOd,DateDo));
               

                    //this.PodrozeDataSet.ViewerRaport.


                

                  //  this.BusinessTripsTableAdapter.Fill(this.PodrozeDataSet.BusinessTrips);
                    
                    this.reportViewer1.RefreshReport();

                }
            else
                {
                    
                this.ViewerRaportTableAdapter.Fill(this.PodrozeDataSet.ViewerRaport);




               // this.BusinessTripsTableAdapter.Fill(this.PodrozeDataSet.BusinessTrips);
                
                this.reportViewer1.RefreshReport();
                }
        }




        private void textBoxDO_Click_1(object sender, EventArgs e)
        {
            String s = textBoxOD.Text;
            DateTime minDate = DateTime.ParseExact(textBoxOD.Text, "yyyy-MM-dd", null);
            calendar_Click(textBoxDO, minDate);
            
        }

        private void textBoxOD_Click(object sender, EventArgs e)
        {
            calendar_Click(textBoxOD);
     
        }
    }
}
