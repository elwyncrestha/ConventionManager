using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConventionManager.View_Controller
{
    public class FormLoader
    {
        public static void loadHome()
        {
            Form form = new Home();
            form.ShowDialog();
        }

        public static void loadAttendeeForm()
        {
            Form form = new AttendeeForm();
            form.ShowDialog();
        }
        
        public static void loadStallForm()
        {
            Form form = new StallForm();
            form.ShowDialog();
        }

        public static void loadRoomForm()
        {
            Form form = new RoomForm();
            form.ShowDialog();
        }

        public static void loadEventForm()
        {
            Form form = new EventForm();
            form.ShowDialog();
        }

        public static void loadSeminarForm()
        {
            Form form = new SeminarForm();
            form.ShowDialog();
        }

        public static void loadAddAttendeeToStallForm()
        {
            Form form = new AddAttendeeToStall();
            form.ShowDialog();
        }

        public static void loadAddAttendeeToEventForm()
        {
            Form form = new AddAttendeeToEvent();
            form.ShowDialog();
        }

        public static void loadAddAttendeeToSeminarForm()
        {
            Form form = new AddAttendeeToSeminar();
            form.ShowDialog();
        }

        public static void loadRoomUsageForm()
        {
            Form form = new RoomUsageForm();
            form.ShowDialog();
        }

        public static void loadAttendeeDetailForm(bool isAdmin, string email)
        {
            Form form = new AttendeeDetail(isAdmin, email);
            form.ShowDialog();
        }

        public static void loadConventionManager()
        {
            Form form = new ConventionManager();
            form.ShowDialog();
        }
    }
}
