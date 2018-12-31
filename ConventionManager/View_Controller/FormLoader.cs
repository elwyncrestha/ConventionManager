using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConventionManager.View_Controller
{
    public class FormLoader
    {
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
    }
}
