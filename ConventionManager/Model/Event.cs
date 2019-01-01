using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConventionManager.Model
{
    public class Event
    {
        public Event()
        {
            this.AttendeeEvent = new HashSet<AttendeeEvent>();
        }

        [Key]
        public int EventId { get; set; }
        public string EventName { get; set; }
        public DateTime EventStartDate { get; set; }
        public DateTime EventEndDate { get; set; }
        public string EventDescription { get; set; }
        public int RoomId { get; set; }

        public virtual Room Room { get; set; }
        public virtual ICollection<AttendeeEvent> AttendeeEvent { get; set; }
    }
}
