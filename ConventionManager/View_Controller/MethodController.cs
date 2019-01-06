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

        private bool dateAvailable(DateTime start, DateTime end, DateTime startDate, DateTime endDate)
        {
            /*
             * Elvin Test Data eg:
             * startDate-endDate: 2020-2024
             * 
             * start-end total possible combinations:
             * Date Range |  return
             * 2019-2025  |  false
             * 2019-2022  |  false
             * 2021-2023  |  false
             * 2023-2025  |  false
             * 2018-2019  |  true
             * 2025-2026  |  true
             */
            if (DateTime.Compare(startDate, start) < 0 && DateTime.Compare(endDate, start) < 0 &&
                DateTime.Compare(startDate, end) < 0 && DateTime.Compare(endDate, end) < 0)
                return true;
            else if (DateTime.Compare(startDate, start) > 0 && DateTime.Compare(endDate, start) > 0 &&
                    DateTime.Compare(startDate, end) > 0 && DateTime.Compare(endDate, end) > 0)
                return true;
            else
                return false;
        }

        public bool roomStatus(int roomId, DateTime startDate, DateTime endDate)
        {
            // check event
            List<Event> eventList = dbContext.Events.Where(a => a.RoomId==roomId).ToList();
            foreach(Event _eve in eventList)
            {
                DateTime start = _eve.EventStartDate;
                DateTime end = _eve.EventEndDate;

                if (!dateAvailable(start, end, startDate, endDate))
                    return false;
            }

            // check seminar
            List<Seminar> seminarList = dbContext.Seminars.Where(a => a.RoomId == roomId).ToList();
            foreach(Seminar seminar in seminarList)
            {
                DateTime start = seminar.SeminarStartDate;
                DateTime end = seminar.SeminarEndDate;

                if (!dateAvailable(start, end, startDate, endDate))
                    return false;
            }

            return true;
        }

        public bool attendeeStatus(int attendeeId, DateTime startDate, DateTime endDate)
        {
            // check  event
            List<Event> eventList = dbContext.AttendeeEvents.Where(ae => ae.AttendeeId == attendeeId).Select(ae => ae.Event).ToList();
            foreach(Event _eve in eventList)
            {
                DateTime start = _eve.EventStartDate;
                DateTime end = _eve.EventEndDate;

                if (!dateAvailable(start, end, startDate, endDate))
                    return false;
            }

            // check seminar
            List<Seminar> seminarList = dbContext.AttendeeSeminars.Where(a => a.AttendeeId == attendeeId).Select(a => a.Seminar).ToList();
            foreach (Seminar seminar in seminarList)
            {
                DateTime start = seminar.SeminarStartDate;
                DateTime end = seminar.SeminarEndDate;

                if (!dateAvailable(start, end, startDate, endDate))
                    return false;
            }

            // check stall
            List<Stall> stallList = dbContext.AttendeeStalls.Where(a => a.AttendeeId == attendeeId).Select(a => a.Stall).ToList();
            foreach (Stall stall in stallList)
            {
                DateTime start = stall.StallStartDate;
                DateTime end = stall.StallEndDate;

                if (!dateAvailable(start, end, startDate, endDate))
                    return false;
            }

            return true;
        }

    }
}
