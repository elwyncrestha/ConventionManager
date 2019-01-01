using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConventionManager.Model
{
    public class Attendee
    {
        public Attendee()
        {
            this.AttendeeStall = new HashSet<AttendeeStall>();
            this.AttendeeEvent = new HashSet<AttendeeEvent>();
            this.AttendeeSeminar = new HashSet<AttendeeSeminar>();
        }

        [Key]
        public int AttendeeId { get; set; }
        public string AttendeeFName { get; set; }
        public string AttendeeLName { get; set; }
        [EmailAddress]
        public string AttendeeEmail { get; set; }
        public string AttendeeContact { get; set; }
        public string AttendeeAddress { get; set; }
        public string TicketType { get; set; }
        public int AttendingDays { get; set; }
        public bool IsAvailable { get; set; }

        public virtual ICollection<AttendeeStall> AttendeeStall { get; set; }
        public virtual ICollection<AttendeeEvent> AttendeeEvent { get; set; }
        public virtual ICollection<AttendeeSeminar> AttendeeSeminar { get; set; }
    }
}
