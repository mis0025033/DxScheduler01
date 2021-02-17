using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Scheduler01.Models
{
    public partial class BookingData
    {
        public static readonly IEnumerable<Booking> Bookings = new[] {
            new Booking {
                Id = 1,
                RoomId = "PET-CT",
                Date = "2021-02-03 12:00",
                Time = "2021-02-03 12:15",
                Duration = 15,
                DoctorId = "DR TEST1",
                Address = "Address 001",
                StatusId = 1
            },

            new Booking {
                Id = 2,
                RoomId = "PET-CT",
                Date = "2021-02-03 12:15",
                Time = "2021-02-03 12:30",
                Duration = 15,
                DoctorId = "DR TEST2",
                Address = "Address 002",
                StatusId = 3
            },

            new Booking {
                Id = 3,
                RoomId = "PET-CT",
                Date = "2021-02-03 12:30",
                Time = "2021-02-03 12:45",
                Duration = 15,
                DoctorId = "DR TEST2",
                Address = "Address 003",
                StatusId = 4
            },

            new Booking {
                Id = 4,
                RoomId = "ROOM-12",
                Date = "2021-02-03 13:00",
                Time = "2021-02-03 13:15",
                Duration = 15,
                DoctorId = "DR PETER CHAN",
                Address = "Address 004",
                StatusId = 2
            },

            new Booking {
                Id = 5,
                RoomId = "ROOM-203",
                Date = "2021-02-03 13:30",
                Time = "2021-02-03 13:45",
                Duration = 15,
                DoctorId = "DR PETER CHAN",
                Address = "Address 005",
                StatusId = 1
            },

            new Booking {
                Id = 6,
                RoomId = "ROOM-1",
                Date = "2021-02-02 09:30",
                Time = "2021-02-02 09:45",
                Duration = 15,
                DoctorId = "DR PETER CHAN",
                Address = "Address 006",
                StatusId = 3
            },

            new Booking {
                Id = 7,
                RoomId = "ROOM-1",
                Date = "2021-02-04 13:15",
                Time = "2021-02-04 13:30",
                Duration = 15,
                DoctorId = "DR TEST3",
                Address = "Address 007",
                StatusId = 4
            },
        };
    }
}