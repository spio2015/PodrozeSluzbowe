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
        private string lat;
        private string lng;

        public Form1()
        {
            InitializeComponent();
            LoadCarsToCombox();
        }

        private void btnGenerateRoute_Click(object sender, EventArgs e)
        {
            //string key = tbxAppKey.Text;
            //tbxDistance.Text = "";
            //tbxDuration.Text = "";
            //Dictionary<string, string> result = GenerateRoute.GetDistance(tbxStartAddress.Text, tbxEndAddress.Text, key);
            //if (result.ContainsKey("start_address")) tbxStartAddress.Text = result["start_address"];
            //if (result.ContainsKey("start_location_lat") && result.ContainsKey("start_location_lng"))
            //    tbxStartLocation.Text = result["start_location_lat"] + "," + result["start_location_lng"];
            //if (result.ContainsKey("end_address")) tbxEndAddress.Text = result["end_address"];
            //if (result.ContainsKey("end_location_lat") && result.ContainsKey("end_location_lng"))
            //    tbxEndLocation.Text = result["end_location_lat"] + "," + result["end_location_lng"];
            //if (result.ContainsKey("distance")) tbxDistance.Text = result["distance"];
            //if (result.ContainsKey("duration")) tbxDuration.Text = result["duration"];

            //webBrowser.Navigate("https://www.google.pl/maps/dir/" + result["start_location_lat"] + "," + result["start_location_lng"] + "/" + result["end_location_lat"] + "," + result["end_location_lng"]);
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser.Navigate("http://maps.google.com/maps?q=loc:" + tbxStartLocation.Text);
            //ProcessStartInfo sInfo = new ProcessStartInfo("http://maps.google.com/maps?q=loc:" + tbxStartLocation.Text);
            //Process.Start(sInfo);
        }

        private void calendar_DoubleClick(object sender, EventArgs e)
        {
            kalendarz _kalendarz = new kalendarz();
            _kalendarz.ShowDialog();
            TextBox tbx = (TextBox)sender;
            tbx.Text = _kalendarz.data;
        }

        private void btnSearchTravels_Click(object sender, EventArgs e)
        {
            int tolerance = 0;
            int.TryParse(tbxTolerance.Text, out tolerance);
            if (tbxDeparture.Text != "" && tbxArrival.Text != "" && !string.IsNullOrEmpty(lat) && !string.IsNullOrEmpty(lng))
            {
                dataGridView1.DataSource = BusinessClasses.MenageContext.GetTravelsList(DateTime.ParseExact(tbxDeparture.Text, "yyyy-MM-dd", null),
                                                                                        DateTime.ParseExact(tbxArrival.Text, "yyyy-MM-dd", null), tolerance, lat, lng);
            }
        }

        private void tbxStartAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                string key = tbxAppKey.Text;
                Dictionary<string, string> result = GoogleApi.GenerateGeolocation.GetGeoloacation(tbxStartAddress.Text, key);
                tbxStartAddress.Text = result["formatted_address"];
                lat = result["lat"].Replace(',', '.');
                lng = result["lng"].Replace(',', '.');
                webBrowser.Navigate(string.Format("http://maps.google.com/maps?q={0},{1}", lat, lng));
            }
        }

        private void LoadCarsToCombox()
        {
            cmbCars.DataSource = BusinessClasses.MenageContext.GetCars();
            cmbCars.DisplayMember = "CmbCars";
            cmbCars.ValueMember = "Id";
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                BusinessClasses.TravelsGrid travel = (BusinessClasses.TravelsGrid)dataGridView1.SelectedRows[0].DataBoundItem;
                {
                    webBrowser.Navigate(string.Format("http://maps.google.com/maps?saddr=52.4022813,16.9496191&daddr={2},{3}+to:{0},{1}&dirflg=d", travel.Lat, travel.Lng, lat, lng));
                }
            }            
        }
    }
}
