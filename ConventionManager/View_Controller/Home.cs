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

        private void mstrManageAttendee_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLoader.loadAttendeeForm();
            this.Close();
        }

        private void mstrManageStall_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLoader.loadStallForm();
            this.Close();
        }

        private void mstrManageRoom_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLoader.loadRoomForm();
            this.Close();
        }

        private void mstrManageEvent_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLoader.loadEventForm();
            this.Close();
        }

        private void mstrManageSeminar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLoader.loadSeminarForm();
            this.Close();
        }

        private void mstrAddAttendeeToStall_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLoader.loadAddAttendeeToStallForm();
            this.Close();
        }

        private void mstrAddAttendeeToEvent_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLoader.loadAddAttendeeToEventForm();
            this.Close();
        }

        private void mstrAddAttendeeToSeminar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLoader.loadAddAttendeeToSeminarForm();
            this.Close();
        }

        private void mstrRoomUsage_Click(object sender, EventArgs e)
        {
            this.Hide();
            RoomUsageForm form = new RoomUsageForm();
            form.ShowDialog();
            this.Close();
        }

        private void mstrViewAttendeeDetail_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLoader.loadAttendeeDetailForm(true, "");
            this.Close();
        }
    }
}
