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
            loadDGV();
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

        private void loadDGV()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("SeminarId", typeof(int));
            dt.Columns.Add("AttendeeId", typeof(int));
            dt.Columns.Add("SeminarName", typeof(string));
            dt.Columns.Add("AttendeeEmail", typeof(string));
            dt.Columns.Add("IsPresenter", typeof(bool));
            List<AttendeeSeminar> list = dbContext.AttendeeSeminars.ToList();
            foreach (AttendeeSeminar a in list)
                dt.Rows.Add(a.SeminarId, a.AttendeeId, a.Seminar.SeminarName, a.Attendee.AttendeeEmail, a.IsPresenter);
            dgvAttendeeSeminar.DataSource = dt;
            dgvAttendeeSeminar.Columns["AttendeeId"].Visible = false;
            dgvAttendeeSeminar.Columns["SeminarId"].Visible = false;
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
                lblFirstNameValue.Text = lblLastNameValue.Text = lblContactValue.Text = lblRoomCapacityValue.Text = "Choose attendee";
            }
        }

        private void cbxSeminar_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                updateGBXSeminar((int)cbxSeminar.SelectedValue);
            }
            catch (Exception ex)
            {
                lblSeminarStartDateValue.Text = lblSeminarEndDateValue.Text = lblRoomNameValue.Text = lblFilledValue.Text = "Choose seminar";
            }
        }

        private void updateGBXSeminar(int seminarId)
        {
            Seminar seminar = dbContext.Seminars.Find(seminarId);
            lblSeminarStartDateValue.Text = seminar.SeminarStartDate.ToString();
            lblSeminarEndDateValue.Text = seminar.SeminarEndDate.ToString();
            lblRoomNameValue.Text = seminar.Room.RoomName;
            lblFilledValue.Text = dbContext.AttendeeSeminars.Where(a => a.SeminarId == seminarId).Count().ToString();
            lblRoomCapacityValue.Text = seminar.Room.RoomCapacity.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //using (dbContext = new ConventionManagerDbContext())
            //{
            MethodController methodController = new MethodController();
            if (methodController.roomCapacityStatus((int)cbxSeminar.SelectedValue,false))
            {
                AttendeeSeminar attendeeSeminar = new AttendeeSeminar()
                {
                    AttendeeId = (int)cbxAttendee.SelectedValue,
                    SeminarId = (int)cbxSeminar.SelectedValue,
                    IsPresenter = chkIsPresenter.Checked
                };

                Seminar seminar = dbContext.Seminars.Find(attendeeSeminar.SeminarId);
                if (methodController.attendeeStatus(attendeeSeminar.AttendeeId, seminar.SeminarStartDate, seminar.SeminarEndDate))
                {
                    dbContext.AttendeeSeminars.Add(attendeeSeminar);
                    try
                    {
                        dbContext.SaveChanges();

                        MessageBox.Show("Attendee added to the seminar successfully!!!");
                        updateGBXSeminar((int)cbxSeminar.SelectedValue);
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

        private void AddAttendeeToSeminar_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            FormLoader.loadHome();
            this.Close();
        }

        private void dgvAttendeeSeminar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAttendeeSeminar.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.Equals("Delete"))
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure?", "Confirm deletion", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int attendeeId = Convert.ToInt32(dgvAttendeeSeminar.Rows[e.RowIndex].Cells["AttendeeId"].Value);
                    int seminarId = Convert.ToInt32(dgvAttendeeSeminar.Rows[e.RowIndex].Cells["SeminarId"].Value);
                    AttendeeSeminar attendeeSeminar = dbContext.AttendeeSeminars.Where(a => a.AttendeeId == attendeeId).Where(a => a.SeminarId == seminarId).Single();
                    dbContext.AttendeeSeminars.Remove(attendeeSeminar);
                    dbContext.SaveChanges();
                    MessageBox.Show("Attendee removed from the seminar!!!");
                    loadDGV();
                    return;
                }
            }
        }
    }
}
