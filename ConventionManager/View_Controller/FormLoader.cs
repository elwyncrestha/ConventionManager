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
        static Form form;
        public static void loadHome()
        {
            form = new Home();
            form.ShowDialog();
        }

        public static void loadAttendeeForm()
        {
            form = new AttendeeForm();
            form.ShowDialog();
        }
        
        public static void loadStallForm()
        {
            form = new StallForm();
            form.ShowDialog();
        }

        public static void loadRoomForm()
        {
            form = new RoomForm();
            form.ShowDialog();
        }

        public static void loadEventForm()
        {
            form = new EventForm();
            form.ShowDialog();
        }

        public static void loadSeminarForm()
        {
            form = new SeminarForm();
            form.ShowDialog();
        }

        public static void loadAddAttendeeToStallForm()
        {
            form = new AddAttendeeToStall();
            form.ShowDialog();
        }

        public static void loadAddAttendeeToEventForm()
        {
            form = new AddAttendeeToEvent();
            form.ShowDialog();
        }

        public static void loadAddAttendeeToSeminarForm()
        {
            form = new AddAttendeeToSeminar();
            form.ShowDialog();
        }

        public static void loadRoomUsageForm()
        {
            form = new RoomUsageForm();
            form.ShowDialog();
        }

        public static void loadAttendeeDetailForm(bool isAdmin, string email)
        {
            form = new AttendeeDetail(isAdmin, email);
            form.ShowDialog();
        }

        public static void loadConventionManager()
        {
            form = new ConventionManager();
            form.ShowDialog();
        }
    }
}
