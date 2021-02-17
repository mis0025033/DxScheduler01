using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Scheduler01.Models
{

    public class Booking
    {
        public int Id { get; set; }
        public string RoomId { get; set; }
        public string Date{ get; set; }
        public string Time{ get; set; }
        public int Duration{ get; set; }
        public string Type{ get; set; }
        public string Casecd { get; set; }
        public string DoctorId { get; set; }
        public int StatusId { get; set; } 
        public string PatientName { get; set; }
        public string Hkid { get; set; }
        public string Address { get; set; }
    }
}