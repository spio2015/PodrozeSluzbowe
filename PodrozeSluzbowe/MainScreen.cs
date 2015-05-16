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

using PodrozeSluzbowe.Supervisor;

namespace PodrozeSluzbowe
{
    public partial class MainScreen : Form
    {
        private string lat;
        private string lng;

        public MainScreen()
        {
            InitializeComponent();
            LoadCarsToCombox();
            LoadUsersToCombox();
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

        private void calendar_Click(TextBox textBox, DateTime MinDate)
        {
            kalendarz _kalendarz = new kalendarz(MinDate);
            _kalendarz.ShowDialog();
            if (_kalendarz.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                textBox.Text = _kalendarz.data;
                tbxArrival.Enabled = true;
                tbxArrival.BackColor = Color.White;
            }            
        }

        private void btnSearchTravels_Click(object sender, EventArgs e)
        {
            LoadTravels();
        }

        private void LoadTravels()
        {
            int tolerance = 0;
            int.TryParse(tbxTolerance.Text, out tolerance);
            if (tbxDeparture.Text != "" && tbxArrival.Text != "" && !string.IsNullOrEmpty(lat) && !string.IsNullOrEmpty(lng))
            {
                dataGridView1.DataSource = BusinessClasses.MenageContext.GetTravelsList(DateTime.ParseExact(tbxDeparture.Text, "yyyy-MM-dd", null),
                                                                                        DateTime.ParseExact(tbxArrival.Text, "yyyy-MM-dd", null), tolerance, lat, lng);
            }
            LoadCarsToCombox();
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

        void  LoadUsersToCombox()
        {
            SuperVisorUsers superV = new SuperVisorUsers();
            cmbBoxUsers.DataSource = superV.getUsersLogins();
        }


        private void LoadCarsToCombox()
        {
            List<string> registrations = new List<string>();
            foreach (DataGridViewRow dgrv in dataGridView1.Rows)
            {
                BusinessClasses.TravelsGrid tg = (BusinessClasses.TravelsGrid)dgrv.DataBoundItem;
                registrations.Add(tg.RegistrationNumber);
            }

            cmbCars.DataSource = BusinessClasses.MenageContext.GetCars(registrations);
            cmbCars.DisplayMember = "CmbCars";
            cmbCars.ValueMember = "Id";
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                BusinessClasses.TravelsGrid travel = (BusinessClasses.TravelsGrid)dataGridView1.SelectedRows[0].DataBoundItem;
                {
                    string latlng1 = lat + "," + lng;
                    string latlng2 = travel.Lat + "," + travel.Lng;
                    Dictionary<string, string> result1 = GoogleApi.GenerateRoute.GetDistance(Properties.Settings.Default.CompanyLatLng, latlng1, "", "&waipoints=" + latlng2);
                    double distance1 = 0;
                    double.TryParse(result1["distance2"], out distance1);
                    Dictionary<string, string> result2 = GoogleApi.GenerateRoute.GetDistance(Properties.Settings.Default.CompanyLatLng, latlng2, "", "&waipoints=" + latlng1);
                    double distance2 = 0;
                    double.TryParse(result2["distance2"], out distance2);
                    if (distance1 < distance2)
                    {
                        webBrowser.Navigate(string.Format("http://maps.google.com/maps?saddr={0}&daddr={1}+to:{2}&dirflg=d", Properties.Settings.Default.CompanyLatLng, latlng1, latlng2));
                    }
                    else
                    {
                        webBrowser.Navigate(string.Format("http://maps.google.com/maps?saddr={0}&daddr={1}+to:{2}&dirflg=d", Properties.Settings.Default.CompanyLatLng, latlng2, latlng1));
                    }
                }
            }            
        }

        private void panelAdministracyjnyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PanelAdministracyjny panelAdm = new PanelAdministracyjny();
            panelAdm.Show();
        }

        private void btnRemoveTrip_Click(object sender, EventArgs e)
        {
            BusinessClasses.TravelsGrid travelsGrid = (BusinessClasses.TravelsGrid)dataGridView1.SelectedRows[0].DataBoundItem;
            BusinessClasses.MenageContext.RemoveTrip(travelsGrid.TripId);
            LoadTravels();
        }

        private void btnAddTrip_Click(object sender, EventArgs e)
        {
            AddJoinTrip((int)cmbCars.SelectedValue, DateTime.ParseExact(tbxDeparture.Text, "yyyy-MM-dd", null), DateTime.ParseExact(tbxArrival.Text, "yyyy-MM-dd", null));
        }

        private void AddJoinTrip(int CarsId, DateTime Departure, DateTime Arrival)
        {
            int idDestination = BusinessClasses.MenageContext.AddDestination(tbxStartAddress.Text, lat, lng);
            
//            int idUser = BusinessClasses.MenageContext.GetUserId(tbxLogin.Text);
            int idUser = BusinessClasses.MenageContext.GetUserId(cmbBoxUsers.SelectedItem.ToString());        
            if (idUser != -1)
            {
                BusinessClasses.MenageContext.AddBusinessTrip(CarsId, idDestination, idUser, Departure, Arrival);
                LoadTravels();
            }
        }

        private void btnJoinToTravel_Click(object sender, EventArgs e)
        {
            BusinessClasses.TravelsGrid tg = (BusinessClasses.TravelsGrid)dataGridView1.SelectedRows[0].DataBoundItem;
            AddJoinTrip(BusinessClasses.MenageContext.GetCarIdByRegistration(tg.RegistrationNumber), tg.DepartureDate, tg.ArrivalDate);
        }

        private void raportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRaport raportForm = new FormRaport();
            raportForm.Show();
        }

        private void wyjścieToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy chcesz wyjść z aplikacji?", "Wyjście", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void tbxDeparture_Click(object sender, EventArgs e)
        {
            calendar_Click(tbxDeparture, DateTime.Today);
        }

        private void tbxArrival_Click(object sender, EventArgs e)
        {
            DateTime minDate = DateTime.ParseExact(tbxDeparture.Text, "yyyy-MM-dd", null);
            calendar_Click(tbxArrival, minDate);
        }

        private void tbxDeparture_TextChanged(object sender, EventArgs e)
        {
            tbxArrival.Text = "";
        }

        private void tbxTolerance_Validating(object sender, CancelEventArgs e)
        {
            int tolerance = 0;
            if (!(int.TryParse(tbxTolerance.Text, out tolerance) || tbxTolerance.Text == ""))
            {
                MessageBox.Show("W polu powinna znaleźć się wartość liczbowa, lub pole powinno pozostać puste.");
                e.Cancel = true;
            }

        }
    }
}