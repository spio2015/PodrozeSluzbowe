using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PodrozeSluzbowe
{
    public partial class kalendarz : Form
    {
        public string data { get; set; }
        public kalendarz()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            this.data = e.Start.ToShortDateString();
            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}
