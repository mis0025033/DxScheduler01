using Scheduler01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Scheduler01.ViewModels
{
    public class SchedulerViewModel
    {
        public IEnumerable<Booking> Bookings { get; set; }
        public IEnumerable<Doctor> Doctors { get; set; }
        public IEnumerable<Room> Rooms { get; set; }
        public IEnumerable<Status> StatusList { get; set; }
    }
}