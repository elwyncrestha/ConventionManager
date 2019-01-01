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
using System.Data.Entity;

namespace ConventionManager.View_Controller
{
    public partial class EventForm : Form
    {
        ConventionManagerDbContext dbContext = new ConventionManagerDbContext();
        Event eventObj;

        public EventForm()
        {
            InitializeComponent();
        }

        private void EventForm_Load(object sender, EventArgs e)
        {
            loadComboBox();
            loadDGV();
        }

        private void loadComboBox()
        {
            cbxRoom.DataSource = dbContext.Rooms.ToList();
            cbxRoom.DisplayMember = "RoomName";
            cbxRoom.ValueMember = "RoomId";
        }

        private void loadDGV()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("EventId", typeof(int));
            dataTable.Columns.Add("EventName", typeof(string));
            dataTable.Columns.Add("EventDescription", typeof(string));
            dataTable.Columns.Add("EventStartDate", typeof(DateTime));
            dataTable.Columns.Add("EventEndDate", typeof(DateTime));
            dataTable.Columns.Add("RoomName", typeof(string));
            dataTable.Columns.Add("RoomCapacity", typeof(int));
            foreach (Event ev in dbContext.Events.ToList())
                dataTable.Rows.Add(ev.EventId, ev.EventName, ev.EventDescription, ev.EventStartDate, ev.EventEndDate, ev.Room.RoomName, ev.Room.RoomCapacity);

            dgvEvent.DataSource = dataTable;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Please enter event name!!!");
                txtName.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(txtDescription.Text))
            {
                MessageBox.Show("Please enter event description!!!");
                txtDescription.Focus();
                return;
            }
            else if(DateTime.Compare(dtpStartDate.Value,DateTime.Now) < 0)
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
                    eventObj = new Event();
                else if (btnAdd.Text.Equals("UPDATE"))
                    eventObj.EventId = eventCode;

                eventObj.EventName = txtName.Text.Trim();
                eventObj.EventDescription = txtDescription.Text.Trim();
                eventObj.EventStartDate = dtpStartDate.Value;
                eventObj.EventEndDate = dtpEndDate.Value;
                eventObj.RoomId = Convert.ToInt32(cbxRoom.SelectedValue.ToString());

                try
                {
                    if (btnAdd.Text.Equals("ADD"))
                        dbContext.Events.Add(eventObj);

                    dbContext.SaveChanges();

                    MessageBox.Show(String.Format("Event {0} successfully!!!", btnAdd.Text.Equals("ADD") ? "added" : "updated"));
                    btnAdd.Text = "ADD";

                    txtName.Clear();
                    txtDescription.Clear();

                    loadDGV();
                    txtName.Focus();
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void cbxRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int roomId = Convert.ToInt32(cbxRoom.SelectedValue.ToString());
                Room room = dbContext.Rooms.Find(roomId);
                lblCapacityValue.Text = room.RoomCapacity.ToString();
            } catch (Exception ex)
            {
                lblCapacityValue.Text = "Select room first";
            }
        }

        int eventCode;
        private void dgvEvent_Click(object sender, EventArgs e)
        {
            eventCode = int.Parse(dgvEvent.CurrentRow.Cells["EventId"].Value.ToString());
            int columnIndex = dgvEvent.CurrentCell.ColumnIndex;

            if (dgvEvent.CurrentRow.Cells[columnIndex].Value.ToString().Equals("Edit"))
            {
                btnAdd.Text = "UPDATE";
                eventObj = dbContext.Events.Find(eventCode);
                txtName.Text = eventObj.EventName;
                txtDescription.Text = eventObj.EventDescription;
                dtpStartDate.Value = eventObj.EventStartDate;
                dtpEndDate.Value = eventObj.EventEndDate;
                cbxRoom.SelectedValue = eventObj.RoomId;
            }
            else if (dgvEvent.CurrentRow.Cells[columnIndex].Value.ToString().Equals("Delete"))
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure ?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    dbContext.Events.Remove(dbContext.Events.Find(eventCode));
                    dbContext.SaveChanges();
                    loadDGV();
                }
                btnAdd.Text = "ADD";
            }
        }
    }
}
