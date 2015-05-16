using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PodrozeSluzbowe
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoginWindow lw = new LoginWindow();
            DialogResult dr = lw.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Application.Run(new Form1());
            }
        }
    }
}
