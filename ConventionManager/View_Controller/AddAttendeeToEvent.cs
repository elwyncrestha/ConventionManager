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
    public partial class AddAttendeeToEvent : Form
    {
        ConventionManagerDbContext dbContext = new ConventionManagerDbContext();

        public AddAttendeeToEvent()
        {
            InitializeComponent();
        }

        private void AddAttendeeToEvent_Load(object sender, EventArgs e)
        {
            loadAttendees();
            loadEvents();
            loadDGV();
        }

        private void loadAttendees()
        {
            cbxAttendee.DataSource = dbContext.Attendees.ToList();
            cbxAttendee.DisplayMember = "AttendeeEmail";
            cbxAttendee.ValueMember = "AttendeeId";
        }

        private void loadEvents()
        {
            cbxEvent.DataSource = dbContext.Events.ToList();
            cbxEvent.DisplayMember = "EventName";
            cbxEvent.ValueMember = "EventId";
        }

        private void loadDGV()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("EventId", typeof(int));
            dt.Columns.Add("AttendeeId", typeof(int));
            dt.Columns.Add("EventName", typeof(string));
            dt.Columns.Add("AttendeeEmail", typeof(string));
            List<AttendeeEvent> list = dbContext.AttendeeEvents.ToList();
            foreach (AttendeeEvent ae in list)
                dt.Rows.Add(ae.EventId,ae.AttendeeId,ae.Event.EventName, ae.Attendee.AttendeeEmail);
            dgvAttendeeEvent.DataSource = dt;
            dgvAttendeeEvent.Columns["AttendeeId"].Visible = false;
            dgvAttendeeEvent.Columns["EventId"].Visible = false;
        }

        private void cbxAttendee_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Attendee attendee = dbContext.Attendees.Find(cbxAttendee.SelectedValue);
                lblFirstNameValue.Text = attendee.AttendeeFName;
                lblLastNameValue.Text = attendee.AttendeeLName;
                lblContactValue.Text = attendee.AttendeeContact;
            }
            catch (Exception ex)
            {
                lblFirstNameValue.Text = lblLastNameValue.Text = lblContactValue.Text = "Choose attendee";
            }
        }

        private void cbxEvent_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                updateGBXEvent((int)cbxEvent.SelectedValue);
            }
            catch (Exception ex)
            {
                lblEventStartDateValue.Text = lblEventEndDateValue.Text = lblRoomNameValue.Text = lblFilledValue.Text = lblRoomCapacityValue.Text = "Choose event";
            }
        }

        private void updateGBXEvent(int eventId)
        {
            Event _event = dbContext.Events.Find(eventId);
            lblEventStartDateValue.Text = _event.EventStartDate.ToString();
            lblEventEndDateValue.Text = _event.EventEndDate.ToString();
            lblRoomNameValue.Text = _event.Room.RoomName;
            lblFilledValue.Text = dbContext.AttendeeEvents.Where(a => a.EventId == eventId).Count().ToString();
            lblRoomCapacityValue.Text = _event.Room.RoomCapacity.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //using (dbContext = new ConventionManagerDbContext())
            //{
            MethodController methodController = new MethodController();
            if (methodController.roomCapacityStatus((int)cbxEvent.SelectedValue,true))
            {
                AttendeeEvent attendeeEvent = new AttendeeEvent()
                {
                    AttendeeId = (int)cbxAttendee.SelectedValue,
                    EventId = (int)cbxEvent.SelectedValue
                };

                Event _eve = dbContext.Events.Find(attendeeEvent.EventId);
                if (methodController.attendeeStatus(attendeeEvent.AttendeeId, _eve.EventStartDate, _eve.EventEndDate))
                {
                    dbContext.AttendeeEvents.Add(attendeeEvent);

                    try
                    {
                        MessageBox.Show("Attendee:" + attendeeEvent.AttendeeId.ToString() + "\nEvent:" + attendeeEvent.EventId.ToString());
                        dbContext.SaveChanges();

                        MessageBox.Show("Attendee added to the event successfully!!!");
                        updateGBXEvent((int)cbxEvent.SelectedValue);
                        loadDGV();
                        return;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Duplicate entry!!!");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Attendee busy on other event or seminar or stall");
                }
            }
            else
            {
                MessageBox.Show("Booking full!!!");
                return;
            }
            //}
        }

        private void AddAttendeeToEvent_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            FormLoader.loadHome();
            this.Close();
        }

        private void dgvAttendeeEvent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAttendeeEvent.Rows[e.RowIndex].Cells["Delete"].Value.Equals("Delete"))
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure ?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int attendeeId = Convert.ToInt32(dgvAttendeeEvent.Rows[e.RowIndex].Cells["AttendeeId"].Value);
                    int eventId = Convert.ToInt32(dgvAttendeeEvent.Rows[e.RowIndex].Cells["EventId"].Value);
                    AttendeeEvent attendeeEvent = dbContext.AttendeeEvents.Where(ae => ae.AttendeeId == attendeeId).Where(ae => ae.EventId == eventId).Single();
                    dbContext.AttendeeEvents.Remove(attendeeEvent);
                    dbContext.SaveChanges();
                    MessageBox.Show("Attendee removed from the event");
                    loadDGV();
                }
            }
        }
    }
}
