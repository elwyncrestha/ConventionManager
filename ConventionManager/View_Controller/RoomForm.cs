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
    public partial class RoomForm : Form
    {
        ConventionManagerDbContext dbContext = new ConventionManagerDbContext();
        Room room;

        public RoomForm()
        {
            InitializeComponent();
        }

        private void RoomForm_Load(object sender, EventArgs e)
        {
            loadDGV();
        }

        private void loadDGV()
        {
            dgvRoom.DataSource = dbContext.Rooms.ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Please enter room name!!!");
                txtName.Focus();
                return;
            }
            else if(String.IsNullOrEmpty(txtLocationCode.Text))
            {
                MessageBox.Show("Please enter room location code!!!");
                txtLocationCode.Focus();
                return;
            }
            else if(String.IsNullOrEmpty(txtCapacity.Text))
            {
                MessageBox.Show("Please enter room capacity!!!");
                txtCapacity.Focus();
                return;
            }
            else if(String.IsNullOrEmpty(txtResources.Text))
            {
                MessageBox.Show("Please enter room resources!!!");
                txtResources.Focus();
                return;
            }
            else
            {
                if (btnAdd.Text.Equals("ADD"))
                    room = new Room();
                else if (btnAdd.Text.Equals("UPDATE"))
                    room.RoomId = roomCode;

                room.RoomName = txtName.Text.Trim();
                room.RoomLocationCode = txtLocationCode.Text.Trim();
                room.RoomCapacity = Convert.ToInt32(txtCapacity.Text.Trim());
                room.RoomResources = txtResources.Text.Trim();

                try
                {
                    if (btnAdd.Text.Equals("ADD"))
                        dbContext.Rooms.Add(room);

                    dbContext.SaveChanges();
                    MessageBox.Show(String.Format("Room {0} successfully!!!", btnAdd.Text.Equals("ADD") ? "added" : "updated"));
                    btnAdd.Text = "ADD";

                    txtName.Clear();
                    txtLocationCode.Clear();
                    txtCapacity.Clear();
                    txtResources.Clear();

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

        int roomCode;
        private void dgvRoom_Click(object sender, EventArgs e)
        {
            roomCode = int.Parse(dgvRoom.CurrentRow.Cells["RoomId"].Value.ToString());
            int columnIndex = dgvRoom.CurrentCell.ColumnIndex;

            if (dgvRoom.CurrentRow.Cells[columnIndex].Value.ToString().Equals("Edit"))
            {
                btnAdd.Text = "UPDATE";
                room = dbContext.Rooms.Find(roomCode);
                txtName.Text = room.RoomName;
                txtLocationCode.Text = room.RoomLocationCode;
                txtCapacity.Text = room.RoomCapacity.ToString();
                txtResources.Text = room.RoomResources;
            }
            else if (dgvRoom.CurrentRow.Cells[columnIndex].Value.ToString().Equals("Delete"))
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure ?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    dbContext.Rooms.Remove(dbContext.Rooms.Find(roomCode));
                    dbContext.SaveChanges();
                    loadDGV();
                }
                btnAdd.Text = "ADD";
            }
        }
    }
}
