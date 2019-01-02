using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConventionManager.Model;

namespace ConventionManager.View_Controller
{
    public class MethodController
    {
        ConventionManagerDbContext dbContext = new ConventionManagerDbContext();

        // methods
        public bool stallCapacityStatus(string stallName)
        {
            int filled = dbContext.AttendeeStalls.Where(a => a.Stall.StallName.Equals(stallName)).Count();
            int capacity = dbContext.Stalls.Single(a => a.StallName.Equals(stallName)).StallCapacity;    // lazy loading
            return filled < capacity;
        }

        public bool roomCapacityStatus(string roomName, string eventName)
        {
            int filled = dbContext.AttendeeEvents.Where(a => a.Event.EventName.Equals(eventName)).Where(a => a.Event.Room.RoomName.Equals(roomName)).Count();
            int capacity = dbContext.Rooms.Where(a => a.RoomName.Equals(roomName)).Select(a => a.RoomCapacity).Single();    // eager loading
            return filled < capacity;
        }


    }
}
