using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Scheduler01.Models
{
    public partial class BookingData
    {
        public static readonly IEnumerable<Status> StatusList = new[] {
            new Status {
                StatusId = 1,
                Name = "Active",
                Color = "#5894e5"
            },

            new Status {
                StatusId = 2,
                Name = "Inactive",
                Color = "#e55858"
            },

            new Status {
                StatusId = 3,
                Name = "Cancel",
                Color = "#000000"
            },

            new Status {
                StatusId = 4,
                Name = "Completed",
                Color = "#4eb44e"
            },
        };
    }
}