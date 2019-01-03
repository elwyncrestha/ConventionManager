using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConventionManager.Model
{
    public class AttendeeStall
    {
        [Key, Column(Order = 0)]
        public int AttendeeId { get; set; }
        [Key, Column(Order = 1)]
        public int StallId { get; set; }
        public bool IsExhibitor { get; set; }

        public virtual Attendee Attendee { get; set; }
        public virtual Stall Stall { get; set; }
    }
}
