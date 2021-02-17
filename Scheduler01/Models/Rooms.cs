using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Scheduler01.Models
{
    public partial class BookingData
    {
        public static readonly IEnumerable<Room> Rooms = new[] {
            new Room {
                RoomId = "",
                Name = "---"
            },

            new Room {
                RoomId = "ROOM-1",
                Name = "Room 1"
            },

            new Room {
                RoomId = "PET-CT",
                Name = "Pet Ct"
            },

            new Room {
                RoomId = "ROOM-12",
                Name = "Room 12"
            },
            new Room {
                RoomId = "ROOM-203",
                Name = "Room 203"
            }
        };
    }
}