using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConventionManager.View_Controller
{
    public class FormLoader
    {
        public static void loadAddAttendee()
        {
            AddAttendee form = new AddAttendee();
            form.ShowDialog();
        }
        
    }
}
