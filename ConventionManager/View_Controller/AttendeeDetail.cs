using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConventionManager.Model;

namespace ConventionManager.View_Controller
{
    public partial class AttendeeDetail : Form
    {
        ConventionManagerDbContext dbContext = new ConventionManagerDbContext();

        public AttendeeDetail()
        {
            InitializeComponent();
        }

        private void AttendeeDetail_Load(object sender, EventArgs e)
        {
            // load attendee
            cbxAttendee.DataSource = dbContext.Attendees.ToList();
            cbxAttendee.ValueMember = "AttendeeEmail";
            cbxAttendee.ValueMember = "AttendeeId";
        }

        private void loadAttendee(int attendeeId)
        {
            Attendee attendee = dbContext.Attendees.Single(a => a.AttendeeId == attendeeId);
            lblNameValue.Text = attendee.AttendeeFName + " " + attendee.AttendeeLName;
            lblEmailValue.Text = attendee.AttendeeEmail;
            lblContactValue.Text = attendee.AttendeeContact;
            lblAddressValue.Text = attendee.AttendeeAddress;
            lblTicketTypeValue.Text = attendee.TicketType;
            lblAttendingDaysValue.Text = attendee.AttendingDays.ToString();
        }

        private void cbxAttendee_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int attendeeId = Convert.ToInt32(cbxAttendee.SelectedValue);
                loadAttendee(attendeeId);
            }
            catch (Exception ex)
            {
                lblNameValue.Text = lblEmailValue.Text = lblContactValue.Text = lblAddressValue.Text = lblTicketTypeValue.Text = lblAttendingDaysValue.Text = "Select attendee";
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            int attendeeId = Convert.ToInt32(cbxAttendee.SelectedValue);
            //string category = Convert.ToString(cbxCategory.SelectedValue);
            DataTable dt = new DataTable();
            dt.Columns.Add("Registered in", typeof(string));

            List<string> list = dbContext.AttendeeEvents.Where(ae => ae.AttendeeId == attendeeId).Select(ae => ae.Event.EventName).ToList();
            foreach (string entry in list)
                dt.Rows.Add(entry);

            list = dbContext.AttendeeSeminars.Where(a => a.AttendeeId == attendeeId).Select(a => a.Seminar.SeminarName).ToList();
            foreach (string entry in list)
                dt.Rows.Add(entry);

            list = dbContext.AttendeeStalls.Where(a => a.AttendeeId == attendeeId).Select(a => a.Stall.StallName).ToList();
            foreach (string entry in list)
                dt.Rows.Add(entry);

            dgvAttendeeDetails.DataSource = dt;
        }

        private void AttendeeDetail_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            FormLoader.loadHome();
            this.Close();
        }
    }
}
