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
            loadDGV();
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

        private void loadDGV()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("StallId", typeof(int));
            dt.Columns.Add("AttendeeId", typeof(int));
            dt.Columns.Add("StallName", typeof(string));
            dt.Columns.Add("AttendeeEmail", typeof(string));
            dt.Columns.Add("IsExhibitor", typeof(bool));
            List<AttendeeStall> list = dbContext.AttendeeStalls.ToList();
            foreach (AttendeeStall a in list)
                dt.Rows.Add(a.StallId, a.AttendeeId, a.Stall.StallName, a.Attendee.AttendeeEmail, a.IsExhibitor);
            dgvAttendeeStall.DataSource = dt;
            dgvAttendeeStall.Columns["AttendeeId"].Visible = false;
            dgvAttendeeStall.Columns["StallId"].Visible = false;
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
        

        private void dgvAttendeeStall_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (dgvAttendeeStall.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.Equals("Delete"))
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure?", "Confirm deletion", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int attendeeId = Convert.ToInt32(dgvAttendeeStall.Rows[e.RowIndex].Cells["AttendeeId"].Value);
                    int stallId = Convert.ToInt32(dgvAttendeeStall.Rows[e.RowIndex].Cells["StallId"].Value);
                    AttendeeStall attendeeStall = dbContext.AttendeeStalls.Where(a => a.AttendeeId == attendeeId).Where(a => a.StallId == stallId).Single();
                    dbContext.AttendeeStalls.Remove(attendeeStall);
                    dbContext.SaveChanges();
                    MessageBox.Show("Attendee removed from the stall!!!");
                    loadDGV();
                    return;
                }
            }
        }
    }
}
