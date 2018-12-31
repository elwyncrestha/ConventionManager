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
    public partial class AddAttendee : Form
    {
        ConventionManagerDbContext dbContext;
        Attendee attendee;

        public AddAttendee()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtFirstName.Text))
            {
                MessageBox.Show("Please enter first name!!!");
                txtFirstName.Focus();
                return;
            }
            else if(String.IsNullOrEmpty(txtLastName.Text))
            {
                MessageBox.Show("Please enter last name!!!");
                txtLastName.Focus();
                return;
            }
            else if(String.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Please enter email!!!");
                txtEmail.Focus();
                return;
            }
            else if(String.IsNullOrEmpty(txtContact.Text))
            {
                MessageBox.Show("Please enter contact number!!!");
                txtContact.Focus();
                return;
            }
            else if(String.IsNullOrEmpty(txtTicketType.Text))
            {
                MessageBox.Show("Please enter ticket type!!!");
                txtTicketType.Focus();
                return;
            }
            else if(String.IsNullOrEmpty(txtAddress.Text))
            {
                MessageBox.Show("Please enter address!!!");
                txtAddress.Focus();
                return;
            }
            else if(String.IsNullOrEmpty(txtAttendingDays.Text))
            {
                MessageBox.Show("Please enter number of attending days!!!");
                txtAttendingDays.Focus();
                return;
            }
            else
            {
                if (btnAdd.Text.Equals("ADD"))
                    attendee = new Attendee();
                else if (btnAdd.Text.Equals("UPDATE"))
                    attendee.AttendeeId = attendeeCode; // set code to update in save changes

                attendee.AttendeeFName = txtFirstName.Text.Trim();
                attendee.AttendeeLName = txtLastName.Text.Trim();
                attendee.AttendeeEmail = txtEmail.Text.Trim();
                attendee.AttendeeContact = txtContact.Text.Trim();
                attendee.TicketType = txtTicketType.Text.Trim();
                attendee.AttendeeAddress = txtAddress.Text.Trim();
                attendee.AttendingDays = Convert.ToInt32(txtAttendingDays.Text.Trim());
                attendee.IsAvailable = true;

                try
                {
                    if(btnAdd.Text.Equals("ADD"))
                        dbContext.Attendees.Add(attendee);

                    dbContext.SaveChanges();

                    MessageBox.Show(String.Format("Attendee {0} successfully!!!",btnAdd.Text.Equals("ADD")?"added":"updated"));
                    txtFirstName.Clear();
                    txtLastName.Clear();
                    txtEmail.Clear();
                    txtContact.Clear();
                    txtTicketType.Clear();
                    txtAddress.Clear();
                    txtAttendingDays.Clear();
                    reloadDGV();
                    txtFirstName.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void AddAttendee_Load(object sender, EventArgs e)
        {
            lblId.Visible = lblIdValue.Visible = false;
            dbContext = new ConventionManagerDbContext();
            reloadDGV();
        }

        private void reloadDGV()
        {
            dgvAttendees.DataSource = dbContext.Attendees.ToList();
        }

        int attendeeCode;
        private void dgvAttendees_Click(object sender, EventArgs e)
        {
            attendeeCode = int.Parse(dgvAttendees.CurrentRow.Cells["AttendeeId"].Value.ToString());
            int columnIndex = dgvAttendees.CurrentCell.ColumnIndex;

            if(dgvAttendees.CurrentRow.Cells[columnIndex].Value.ToString().Equals("Edit"))
            {
                btnAdd.Text = "UPDATE";
                attendee = dbContext.Attendees.Find(attendeeCode);
                txtFirstName.Text = attendee.AttendeeFName;
                txtLastName.Text = attendee.AttendeeLName;
                txtEmail.Text = attendee.AttendeeEmail;
                txtContact.Text = attendee.AttendeeContact;
                txtTicketType.Text = attendee.TicketType;
                txtAddress.Text = attendee.AttendeeAddress;
                txtAttendingDays.Text = attendee.AttendingDays.ToString();
            }
            else if (dgvAttendees.CurrentRow.Cells[columnIndex].Value.ToString().Equals("Delete"))
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure ?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    dbContext.Attendees.Remove(dbContext.Attendees.Find(attendeeCode));
                    dbContext.SaveChanges();
                    reloadDGV();
                }
            }
        }
    }
}
