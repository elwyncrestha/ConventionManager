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
    public partial class AddAttendeeToSeminar : Form
    {
        ConventionManagerDbContext dbContext = new ConventionManagerDbContext();
        public AddAttendeeToSeminar()
        {
            InitializeComponent();
        }

        private void AddAttendeeToSeminar_Load(object sender, EventArgs e)
        {
            loadAttendees();
            loadSeminars();
        }

        private void loadAttendees()
        {
            cbxAttendee.DataSource = dbContext.Attendees.ToList();
            cbxAttendee.DisplayMember = "AttendeeEmail";
            cbxAttendee.ValueMember = "AttendeeId";
        }

        private void loadSeminars()
        {
            cbxSeminar.DataSource = dbContext.Seminars.ToList();
            cbxSeminar.DisplayMember = "SeminarName";
            cbxSeminar.ValueMember = "SeminarId";
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

        private void cbxSeminar_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Seminar seminar = dbContext.Seminars.Find(cbxSeminar.SelectedValue);
                lblSeminarStartDateValue.Text = seminar.SeminarStartDate.ToString();
                lblSeminarEndDateValue.Text = seminar.SeminarEndDate.ToString();
                lblRoomNameValue.Text = seminar.Room.RoomName;
            }
            catch (Exception ex)
            {
                lblSeminarStartDateValue.Text = lblSeminarEndDateValue.Text = lblRoomNameValue.Text = "Choose seminar";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AttendeeSeminar attendeeSeminar = new AttendeeSeminar()
            {
                AttendeeId = (int)cbxAttendee.SelectedValue,
                SeminarId = (int)cbxSeminar.SelectedValue,
                IsPresenter = chkIsPresenter.Checked
            };

            dbContext.AttendeeSeminars.Add(attendeeSeminar);
            try
            {
                dbContext.SaveChanges();

                MessageBox.Show("Attendee added to the seminar successfully!!!");
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
