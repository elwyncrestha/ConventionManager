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
        private bool isAdmin = false;
        private string email = null;
        ConventionManagerDbContext dbContext = new ConventionManagerDbContext();

        public AttendeeDetail(bool isAdmin, string email)
        {
            this.isAdmin = isAdmin;
            this.email = email;
            InitializeComponent();
        }

        private void AttendeeDetail_Load(object sender, EventArgs e)
        {
            // admin filter
            cbxAttendee.Visible = isAdmin;

            // load attendee
            cbxAttendee.DataSource = dbContext.Attendees.ToList();
            cbxAttendee.ValueMember = "AttendeeEmail";
            cbxAttendee.ValueMember = "AttendeeId";
            if (!isAdmin)
                loadAttendee(dbContext.Attendees.Where(a => a.AttendeeEmail.Equals(email)).Select(a => a.AttendeeId).Single());
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
            dt.Columns.Add("Start date", typeof(DateTime));
            dt.Columns.Add("End date", typeof(DateTime));
            dt.Columns.Add("Location", typeof(string));

            List<AttendeeEvent> list1 = dbContext.AttendeeEvents.Where(ae => ae.AttendeeId == attendeeId).ToList();
            foreach (AttendeeEvent entry in list1)
                dt.Rows.Add(entry.Event.EventName,entry.Event.EventStartDate,entry.Event.EventEndDate,entry.Event.Room.RoomLocationCode);

            List<AttendeeSeminar> list2 = dbContext.AttendeeSeminars.Where(a => a.AttendeeId == attendeeId).ToList();
            foreach (AttendeeSeminar entry in list2)
                dt.Rows.Add(entry.Seminar.SeminarName,entry.Seminar.SeminarStartDate,entry.Seminar.SeminarEndDate,entry.Seminar.Room.RoomLocationCode);

            List<AttendeeStall> list3 = dbContext.AttendeeStalls.Where(a => a.AttendeeId == attendeeId).ToList();
            foreach (AttendeeStall entry in list3)
                dt.Rows.Add(entry.Stall.StallName,entry.Stall.StallStartDate,entry.Stall.StallEndDate,entry.Stall.StallLocationCode);

            dgvAttendeeDetails.DataSource = dt;
        }

        private void AttendeeDetail_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            if (isAdmin)
                FormLoader.loadHome();
            else
                FormLoader.loadConventionManager();
            this.Close();
        }
    }
}
