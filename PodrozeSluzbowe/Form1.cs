using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GoogleApi;

namespace PodrozeSluzbowe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerateRoute_Click(object sender, EventArgs e)
        {
            string key = tbxAppKey.Text;
            tbxDistance.Text = "";
            tbxDuration.Text = "";
            Dictionary<string, string> result = GenerateRoute.GetDistance(tbxStartAddress.Text, tbxEndAddress.Text, key);
            if (result.ContainsKey("start_address")) tbxStartAddress.Text = result["start_address"];
            if (result.ContainsKey("start_location_lat") && result.ContainsKey("start_location_lng"))
                tbxStartLocation.Text = result["start_location_lat"] + "," + result["start_location_lng"];
            if (result.ContainsKey("end_address")) tbxEndAddress.Text = result["end_address"];
            if (result.ContainsKey("end_location_lat") && result.ContainsKey("end_location_lng"))
                tbxEndLocation.Text = result["end_location_lat"] + "," + result["end_location_lng"];
            if (result.ContainsKey("distance")) tbxDistance.Text = result["distance"];
            if (result.ContainsKey("duration")) tbxDuration.Text = result["duration"];
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser.Navigate("http://maps.google.com/maps?q=loc:" + tbxStartLocation.Text);
            //ProcessStartInfo sInfo = new ProcessStartInfo("http://maps.google.com/maps?q=loc:" + tbxStartLocation.Text);
            //Process.Start(sInfo);
        }

        private void btnOpenEndLocation_Click(object sender, EventArgs e)
        {
            webBrowser.Navigate("http://maps.google.com/maps?q=loc:" + tbxEndLocation.Text);
            //ProcessStartInfo sInfo = new ProcessStartInfo("http://maps.google.com/maps?q=loc:" + tbxEndLocation.Text);
            //Process.Start(sInfo);
        }

        private void calendar_DoubleClick(object sender, EventArgs e)
        {
            kalendarz _kalendarz = new kalendarz();
            _kalendarz.ShowDialog();
            TextBox tbx = (TextBox)sender;
            tbx.Text = _kalendarz.data;
        }


    }
}
