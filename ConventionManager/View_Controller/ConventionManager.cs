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
    public partial class ConventionManager : Form
    {
        public ConventionManager()
        {
            InitializeComponent();
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtAttendeeEmail.Text))
            {
                MessageBox.Show("Please enter your email address!!!");
                txtAttendeeEmail.Focus();
                return;
            }
            else
            {
                string email = txtAttendeeEmail.Text.Trim();
                ConventionManagerDbContext db = new ConventionManagerDbContext();
                List<Attendee> list = db.Attendees.Where(a => a.AttendeeEmail.Equals(email)).ToList();
                if(list.Count == 0)
                {
                    MessageBox.Show(email + " is not registered!!!");
                    txtAttendeeEmail.Clear();
                    txtAttendeeEmail.Focus();
                    return;
                }
                else
                {
                    this.Hide();
                    FormLoader.loadAttendeeDetailForm(false, email);
                    this.Close();
                }
            }
        }

        Label lblPassword;
        TextBox txtPassword;
        Button btnAdminLogin;
        private void lnkAdmin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lnkAdmin.Text.Equals("- Admin Login"))
            {
                lnkAdmin.Text = "- Attendee Login";
                lblIntro.Text = "Admin username:";
                btnCheckIn.Visible = false;

                // lblPassword
                lblPassword = new Label();
                lblPassword.Location = new Point(6, 124);
                lblPassword.Text = "Admin password:";
                lblPassword.Size = new Size(250, 21);

                // txtPassword
                txtPassword = new TextBox();
                txtPassword.PasswordChar = '*';
                txtPassword.Location = new Point(6, 158);
                txtPassword.Size = new Size(244, 26);
                txtPassword.TabIndex = 2;

                // btnAdminLogin
                btnAdminLogin = new Button();
                btnAdminLogin.Text = "Login";
                btnAdminLogin.Size = new Size(155, 35);
                btnAdminLogin.Location = new Point(42, 200);
                btnAdminLogin.TabIndex = 3;
                btnAdminLogin.Click += (se, ea) =>
                {
                    if (String.IsNullOrEmpty(txtAttendeeEmail.Text))
                    {
                        MessageBox.Show("Please enter username!!!");
                        txtAttendeeEmail.Focus();
                        return;
                    }
                    else if(String.IsNullOrEmpty(txtPassword.Text))
                    {
                        MessageBox.Show("Please enter password!!!");
                        txtPassword.Focus();
                        return;
                    }
                    else
                    {
                        if(txtAttendeeEmail.Text.Trim().Equals("admin") && txtPassword.Text.Trim().Equals("admin"))
                        {
                            this.Hide();
                            FormLoader.loadHome();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Login failed !!!");
                            txtAttendeeEmail.Clear();
                            txtPassword.Clear();
                            txtAttendeeEmail.Focus();
                            return;
                        }
                    }
                };

                gbxConventionManager.Controls.Add(lblPassword);
                gbxConventionManager.Controls.Add(txtPassword);
                gbxConventionManager.Controls.Add(btnAdminLogin);
                txtAttendeeEmail.Focus();
            }
            else
            {
                lnkAdmin.Text = "- Admin Login";
                lblIntro.Text = "Enter email for attendee check-in";
                btnCheckIn.Visible = true;
                lblPassword.Visible = txtPassword.Visible = btnAdminLogin.Visible = false;
                txtAttendeeEmail.Focus();
            }
        }
    }
}
