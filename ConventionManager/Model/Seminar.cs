using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConventionManager.Model
{
    public class Seminar
    {
        public int SeminarId { get; set; }
        public string SeminarName { get; set; }
        public DateTime SeminarStartDate { get; set; }
        public DateTime SeminarEndDate { get; set; }
        public int RoomId { get; set; }
        public virtual Room Room { get; set; }
    }
}
