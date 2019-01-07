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
    public partial class SeminarForm : Form
    {
        ConventionManagerDbContext dbContext = new ConventionManagerDbContext();
        Seminar seminar;

        public SeminarForm()
        {
            InitializeComponent();
        }

        private void loadDGV()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("SeminarId", typeof(int));
            dataTable.Columns.Add("SeminarName", typeof(string));
            dataTable.Columns.Add("SeminarStartDate", typeof(DateTime));
            dataTable.Columns.Add("SeminarEndDate", typeof(DateTime));
            dataTable.Columns.Add("RoomName", typeof(string));
            dataTable.Columns.Add("RoomCapacity", typeof(int));
            dataTable.Columns.Add("No. of Attendee",typeof(int));

            foreach (Seminar sem in dbContext.Seminars.ToList())
                dataTable.Rows.Add(sem.SeminarId, sem.SeminarName, sem.SeminarStartDate, 
                    sem.SeminarEndDate, sem.Room.RoomName, sem.Room.RoomCapacity, 
                    dbContext.AttendeeSeminars.Where(a => a.SeminarId==sem.SeminarId).Count());

            dgvSeminar.DataSource = dataTable;
            dgvSeminar.Columns["SeminarId"].Visible = false;
        }
        private void loadComboBox()
        {
            cbxRoom.DataSource = dbContext.Rooms.ToList();
            cbxRoom.DisplayMember = "RoomName";
            cbxRoom.ValueMember = "RoomId";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Please enter seminar name!!!");
                txtName.Focus();
                return;
            }
            else if (DateTime.Compare(dtpStartDate.Value, DateTime.Now) < 0)
            {
                MessageBox.Show("Invalid start date: Date crossed already!!!");
                dtpStartDate.Focus();
                return;
            }
            else if (DateTime.Compare(dtpStartDate.Value, dtpEndDate.Value) >= 0)
            {
                MessageBox.Show("End date must be after start date!!!");
                dtpStartDate.Focus();
                return;
            }
            else
            {
                if (btnAdd.Text.Equals("ADD"))
                {
                    MethodController controller = new MethodController();
                    if (controller.roomStatus((int)cbxRoom.SelectedValue, dtpStartDate.Value, dtpEndDate.Value))
                        seminar = new Seminar();
                    else
                    {
                        MessageBox.Show("Room unavailable in that time period!!!");
                        return;
                    }
                }
                else if (btnAdd.Text.Equals("UPDATE"))
                    seminar.SeminarId = seminarCode;

                seminar.SeminarName = txtName.Text.Trim();
                seminar.SeminarStartDate = dtpStartDate.Value;
                seminar.SeminarEndDate = dtpEndDate.Value;
                seminar.RoomId = Convert.ToInt32(cbxRoom.SelectedValue.ToString());

                try
                {
                    if (btnAdd.Text.Equals("ADD"))
                        dbContext.Seminars.Add(seminar);

                    dbContext.SaveChanges();

                    MessageBox.Show(String.Format("Seminar {0} successfully!!!", btnAdd.Text.Equals("ADD") ? "added" : "updated"));
                    btnAdd.Text = "ADD";

                    txtName.Clear();

                    loadDGV();
                    dtpStartDate.Enabled = dtpEndDate.Enabled = cbxRoom.Enabled = true;
                    txtName.Focus();
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void SeminarForm_Load(object sender, EventArgs e)
        {
            loadComboBox();
            loadDGV();
        }

        int seminarCode;
        private void dgvSeminar_Click(object sender, EventArgs e)
        {
            seminarCode = int.Parse(dgvSeminar.CurrentRow.Cells["SeminarId"].Value.ToString());
            int columnIndex = dgvSeminar.CurrentCell.ColumnIndex;

            if (dgvSeminar.CurrentRow.Cells[columnIndex].Value.ToString().Equals("Edit"))
            {
                btnAdd.Text = "UPDATE";
                seminar = dbContext.Seminars.Find(seminarCode);
                txtName.Text = seminar.SeminarName;
                dtpStartDate.Value = seminar.SeminarStartDate;
                dtpEndDate.Value = seminar.SeminarEndDate;
                dtpStartDate.Enabled = dtpEndDate.Enabled = cbxRoom.Enabled = false;
                cbxRoom.SelectedValue = seminar.RoomId;
            }
            else if (dgvSeminar.CurrentRow.Cells[columnIndex].Value.ToString().Equals("Delete"))
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure ?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    // on delete cascade only on AttendeeId in AttendeeSeminar
                    // first remove data held by foreign key in AttendeeSeminar
                    var seminars = dbContext.AttendeeSeminars.Where(a => a.SeminarId == seminarCode).ToList();
                    foreach (var del in seminars)
                        dbContext.AttendeeSeminars.Remove(del);
                    dbContext.SaveChanges();

                    // then remove seminar
                    dbContext.Seminars.Remove(dbContext.Seminars.Find(seminarCode));
                    dbContext.SaveChanges();
                    loadDGV();

                    MessageBox.Show("Seminar deleted!!!");
                }
                btnAdd.Text = "ADD";
            }
        }

        private void cbxRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int roomId = Convert.ToInt32(cbxRoom.SelectedValue.ToString());
                Room room = dbContext.Rooms.Find(roomId);
                lblCapacityValue.Text = room.RoomCapacity.ToString();
            }
            catch (Exception ex)
            {
                lblCapacityValue.Text = "Select room first";
            }
        }

        private void SeminarForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            FormLoader.loadHome();
            this.Close();
        }
    }
}
