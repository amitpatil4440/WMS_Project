using System;
using System.Collections.Generic;

namespace WheelChairAPI.Models
{
    public partial class Booking
    {
        public Booking()
        {
            Supervisor = new HashSet<Supervisor>();
        }

        public int? PassengerId { get; set; }
        public int Pnrno { get; set; }
        public string Departure { get; set; }
        public string Arrival { get; set; }
        public DateTime? Date { get; set; }
        public string PassengerName { get; set; }
        public int? GateNo { get; set; }
        public string SeatNo { get; set; }
        public string Class { get; set; }
        public DateTime? Time { get; set; }

        public virtual Passenger Passenger { get; set; }
        public virtual ICollection<Supervisor> Supervisor { get; set; }
    }
}
