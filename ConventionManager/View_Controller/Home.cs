using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConventionManager.View_Controller;

namespace ConventionManager
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void mstrAddAttendee_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLoader.loadAddAttendee();
            this.Close();
        }

        private void mstrDisplayAttendees_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLoader.loadAddAttendee();
            this.Close();
        }
    }
}
