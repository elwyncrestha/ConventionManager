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
    public partial class RoomUsageForm : Form
    {
        ConventionManagerDbContext dbContext = new ConventionManagerDbContext();
        public RoomUsageForm()
        {
            InitializeComponent();
        }

        private void RoomUsageForm_Load(object sender, EventArgs e)
        {
            cbxRoom.DataSource = dbContext.Rooms.ToList();
            cbxRoom.DisplayMember = "RoomName";
            cbxRoom.ValueMember = "RoomId";
        }

        private void cbxRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int roomId = (int)cbxRoom.SelectedValue;
                DataTable dt = new DataTable();
                dt.Columns.Add("Room Name", typeof(string));
                dt.Columns.Add("Usage from", typeof(DateTime));
                dt.Columns.Add("Usage to", typeof(DateTime));
                dt.Columns.Add("Used by", typeof(string));

                List<Event> eventList = dbContext.Events.Where(a => a.RoomId == roomId).ToList();
                foreach(Event _event in eventList)
                    dt.Rows.Add(_event.Room.RoomName, _event.EventStartDate, _event.EventEndDate, _event.EventName);

                List<Seminar> seminarList = dbContext.Seminars.Where(a => a.RoomId == roomId).ToList();
                foreach (Seminar seminar in seminarList)
                    dt.Rows.Add(seminar.Room.RoomName, seminar.SeminarStartDate, seminar.SeminarEndDate, seminar.SeminarName);

                dgvRoomUsage.DataSource = dt;
            }
            catch(Exception ex)
            {
                // do nothing
            }
        }
    }
}
