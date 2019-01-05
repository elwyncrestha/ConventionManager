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
        public bool stallCapacityStatus(int stallId)
        {
            int filled = dbContext.AttendeeStalls.Where(a => a.Stall.StallId==stallId).Count();
            int capacity = dbContext.Stalls.Single(a => a.StallId==stallId).StallCapacity;    // lazy loading
            return filled < capacity;
        }

        public bool roomCapacityStatus(int eventOrSeminarId, bool isEvent)
        {
            int filled=0, roomId=0, capacity=0;
            if (isEvent)
            {
                filled = dbContext.AttendeeEvents.Where(a => a.EventId == eventOrSeminarId).Count();
                roomId = dbContext.Events.Single(a => a.EventId == eventOrSeminarId).Room.RoomId;
                capacity = dbContext.Rooms.Where(a => a.RoomId == roomId).Select(a => a.RoomCapacity).Single();    // eager loading
            }
            else
            {
                filled = dbContext.AttendeeSeminars.Where(a => a.SeminarId == eventOrSeminarId).Count();
                roomId = dbContext.Seminars.Single(a => a.SeminarId == eventOrSeminarId).Room.RoomId;
                capacity = dbContext.Rooms.Where(a => a.RoomId == roomId).Select(a => a.RoomCapacity).Single();    // eager loading
            }
            return filled < capacity;
        }

        public bool roomStatus(int roomId, DateTime startDate, DateTime endDate)
        {
            // check event
            List<Event> eventList = dbContext.Events.ToList();
            foreach(Event _eve in eventList)
            {
                DateTime start = _eve.EventStartDate;
                DateTime end = _eve.EventEndDate;

                if (DateTime.Compare(startDate, start) <= 0 && DateTime.Compare(endDate, start) >= 0)
                    return false;
                else if (DateTime.Compare(startDate, end) <= 0 && DateTime.Compare(endDate, end) >= 0)
                    return false;
            }

            // check seminar
            List<Seminar> seminarList = dbContext.Seminars.ToList();
            foreach(Seminar seminar in seminarList)
            {
                DateTime start = seminar.SeminarStartDate;
                DateTime end = seminar.SeminarEndDate;

                if (DateTime.Compare(startDate, start) <= 0 && DateTime.Compare(endDate, start) >= 0)
                    return false;
                else if (DateTime.Compare(startDate, end) <= 0 && DateTime.Compare(endDate, end) >= 0)
                    return false;
            }

            return true;
        }

    }
}
