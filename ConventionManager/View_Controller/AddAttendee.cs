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
                Attendee attendee = new Attendee()
                {
                    AttendeeFName = txtFirstName.Text.Trim(),
                    AttendeeLName = txtLastName.Text.Trim(),
                    AttendeeEmail = txtEmail.Text.Trim(),
                    AttendeeContact = txtContact.Text.Trim(),
                    TicketType = txtTicketType.Text.Trim(),
                    AttendeeAddress = txtAddress.Text.Trim(),
                    AttendingDays = Convert.ToInt32(txtAttendingDays.Text.Trim()),
                    IsAvailable = true
                };

                try
                {
                    dbContext.Attendees.Add(attendee);
                    dbContext.SaveChanges();

                    MessageBox.Show("Attendee added successfully!!!");
                    txtFirstName.Clear();
                    txtLastName.Clear();
                    txtEmail.Clear();
                    txtContact.Clear();
                    txtTicketType.Clear();
                    txtAddress.Clear();
                    txtAttendingDays.Clear();
                    reloadDGV();

                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void AddAttendee_Load(object sender, EventArgs e)
        {
            dbContext = new ConventionManagerDbContext();
            reloadDGV();
        }

        private void reloadDGV()
        {
            dgvAttendees.DataSource = dbContext.Attendees.ToList();
        }
    }
}
