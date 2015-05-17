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
           
            //jeśli jest data to sprawdzam według daty
            if (textBoxOD.Text.Length > 0 )
                {
                DateTime DateOd = DateTime.ParseExact(textBoxOD.Text, "yyyy-MM-dd", null);
                DateTime DateDo;

                this.ViewerRaportTableAdapter.ClearBeforeFill = true;
                if(rbOdjazd.Checked)
                    {
                    if(textBoxDO.Text.Length == 0)
                        {
                        this.ViewerRaportTableAdapter.FillByOdjazd1(this.PodrozeDataSet.ViewerRaport, DateOd);
                        }
                    else
                        {
                        DateDo = DateTime.ParseExact(textBoxDO.Text, "yyyy-MM-dd", null);
                        this.ViewerRaportTableAdapter.FillByOdjazd2(this.PodrozeDataSet.ViewerRaport, DateOd, DateDo);
                        }
                    }
                else
                    {
                    if(textBoxDO.Text.Length == 0)
                        {
                        this.ViewerRaportTableAdapter.FillByPrzyjazdy1(this.PodrozeDataSet.ViewerRaport, DateOd);
                        }
                    else
                        {
                        DateDo = DateTime.ParseExact(textBoxDO.Text, "yyyy-MM-dd", null);
                        this.ViewerRaportTableAdapter.FillByPrzyjazdy2(this.PodrozeDataSet.ViewerRaport, DateOd, DateDo);
                        }
                    }

                   this.reportViewer1.RefreshReport();

                }
            else
                {                    
                this.ViewerRaportTableAdapter.Fill(this.PodrozeDataSet.ViewerRaport);                
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
