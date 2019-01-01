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
            FormLoader.loadAttendeeForm();
            this.Close();
        }

        private void mstrDisplayAttendees_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLoader.loadAttendeeForm();
            this.Close();
        }

        private void mstrAddStall_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLoader.loadStallForm();
            this.Close();
        }

        private void mstrDisplayStalls_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLoader.loadStallForm();
            this.Close();
        }

        private void mstrAddRoom_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLoader.loadRoomForm();
            this.Close();
        }

        private void mstrAddEvent_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLoader.loadEventForm();
            this.Close();
        }

        private void mstrDisplayEvents_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLoader.loadEventForm();
            this.Close();
        }

        private void mstrAddSeminar_Click(object sender, EventArgs e)
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
    }
}
