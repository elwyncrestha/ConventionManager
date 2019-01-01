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
                Event _event = dbContext.Events.Find(cbxEvent.SelectedValue);
                lblEventStartDateValue.Text = _event.EventStartDate.ToString();
                lblEventEndDateValue.Text = _event.EventEndDate.ToString();
                lblRoomNameValue.Text = _event.Room.RoomName;
            }
            catch (Exception ex)
            {
                lblEventStartDateValue.Text = lblEventEndDateValue.Text = lblRoomNameValue.Text = "Choose event";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AttendeeEvent attendeeEvent = new AttendeeEvent()
            {
                AttendeeId = (int)cbxAttendee.SelectedValue,
                EventId = (int)cbxEvent.SelectedValue
            };

            dbContext.AttendeeEvents.Add(attendeeEvent);
            try
            {
                dbContext.SaveChanges();

                MessageBox.Show("Attendee added to the event successfully!!!");
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Duplicate entry!!!");
                return;
            }
        }
    }
}
