using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
           
            this.ViewerRaportTableAdapter.Fill(this.PodrozeDataSet.ViewerRaport);
          
          

          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BusinessTripsTableAdapter.Fill(this.PodrozeDataSet.BusinessTrips);
          
            this.reportViewer1.RefreshReport();
        }
    }
}
