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
        private DateTime _dateMin;

        public kalendarz()
        {
            InitializeComponent();
        }

        public kalendarz(DateTime DateMin)
        {            
            InitializeComponent();
            _dateMin = DateMin;
            this.monthCalendar1.MinDate = _dateMin;
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            this.data = e.Start.ToShortDateString();
            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}
