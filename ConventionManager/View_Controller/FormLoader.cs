using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConventionManager.View_Controller
{
    public class FormLoader
    {
        public static void loadHome()
        {
            Home form = new Home();
            form.ShowDialog();
        }

        public static void loadAttendeeForm()
        {
            AttendeeForm form = new AttendeeForm();
            form.ShowDialog();
        }
        
        public static void loadStallForm()
        {
            StallForm form = new StallForm();
            form.ShowDialog();
        }

        public static void loadRoomForm()
        {
            RoomForm form = new RoomForm();
            form.ShowDialog();
        }

        public static void loadEventForm()
        {
            EventForm form = new EventForm();
            form.ShowDialog();
        }

        public static void loadSeminarForm()
        {
            SeminarForm form = new SeminarForm();
            form.ShowDialog();
        }

        public static void loadAddAttendeeToStallForm()
        {
            AddAttendeeToStall form = new AddAttendeeToStall();
            form.ShowDialog();
        }

        public static void loadAddAttendeeToEventForm()
        {
            AddAttendeeToEvent form = new AddAttendeeToEvent();
            form.ShowDialog();
        }

        public static void loadAddAttendeeToSeminarForm()
        {
            AddAttendeeToSeminar form = new AddAttendeeToSeminar();
            form.ShowDialog();
        }

        public static void loadRoomUsageForm()
        {
            RoomUsageForm form = new RoomUsageForm();
            form.ShowDialog();
        }

        public static void loadAttendeeDetailForm()
        {
            AttendeeDetail form = new AttendeeDetail();
            form.ShowDialog();
        }
    }
}
