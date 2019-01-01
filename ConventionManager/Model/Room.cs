using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConventionManager.Model
{
    public class Room
    {
        public Room()
        {
            this.Event = new HashSet<Event>();
        }

        [Key]
        public int RoomId { get; set; }
        public string RoomName { get; set; }
        public string RoomLocationCode { get; set; }
        public int RoomCapacity { get; set; }
        public string RoomResources { get; set; }
        public virtual ICollection<Event> Event { get; set; }
    }
}
