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
    public partial class AddAttendeeToStall : Form
    {
        ConventionManagerDbContext dbContext = new ConventionManagerDbContext();

        public AddAttendeeToStall()
        {
            InitializeComponent();
        }

        private void AddAttendeeToStall_Load(object sender, EventArgs e)
        {
            loadAttendees();
            loadStalls();
        }

        private void loadAttendees()
        {
            cbxAttendee.DataSource = dbContext.Attendees.ToList();
            cbxAttendee.DisplayMember = "AttendeeEmail";
            cbxAttendee.ValueMember = "AttendeeId";
        }

        private void loadStalls()
        {
            cbxStall.DataSource = dbContext.Stalls.ToList();
            cbxStall.DisplayMember = "StallName";
            cbxStall.ValueMember = "StallId";
        }

        private void cbxAttendee_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Attendee attendee = dbContext.Attendees.Find(cbxAttendee.SelectedValue);
                lblFirstNameValue.Text = attendee.AttendeeFName;
                lblLastNameValue.Text = attendee.AttendeeLName;
                lblContactValue.Text = attendee.AttendeeContact;
            } catch (Exception ex)
            {
                lblFirstNameValue.Text = lblLastNameValue.Text = lblContactValue.Text = "Choose attendee";
            }
        }

        private void cbxStall_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                updateGBXStall((int)cbxStall.SelectedValue);
            }
            catch (Exception ex)
            {
                lblLocationCodeValue.Text = lblCapacityValue.Text = lblStallTypeValue.Text = lblFilledValue.Text = "Choose stall";
            }
        }

        private void updateGBXStall(int stallId)
        {
            Stall stall = dbContext.Stalls.Find(stallId);
            lblStallTypeValue.Text = stall.StallType;
            lblCapacityValue.Text = stall.StallCapacity.ToString();
            lblLocationCodeValue.Text = stall.StallLocationCode;
            lblFilledValue.Text = dbContext.AttendeeStalls.Where(a => a.StallId == stallId).Count().ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //using (dbContext = new ConventionManagerDbContext())
            //{
            MethodController methodController = new MethodController();
            if (methodController.stallCapacityStatus((int)cbxStall.SelectedValue))
            {
                AttendeeStall attendeeStall = new AttendeeStall()
                {
                    AttendeeId = (int)cbxAttendee.SelectedValue,
                    StallId = (int)cbxStall.SelectedValue,
                    IsExhibitor = chkIsExhibitor.Checked
                };

                Stall stall = dbContext.Stalls.Find(attendeeStall.StallId);
                if (methodController.attendeeStatus(attendeeStall.AttendeeId, stall.StallStartDate, stall.StallEndDate))
                {
                    dbContext.AttendeeStalls.Add(attendeeStall);
                    try
                    {
                        dbContext.SaveChanges();

                        MessageBox.Show("Attendee added to the stall successfully!!!");
                        updateGBXStall((int)cbxStall.SelectedValue);
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
                MessageBox.Show("Stall full!!!");
                return;
            }
            //}
        }

        private void AddAttendeeToStall_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            FormLoader.loadHome();
            this.Close();
        }
    }
}
