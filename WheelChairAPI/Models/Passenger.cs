using System;
using System.Collections.Generic;

namespace WheelChairAPI.Models
{
    public partial class Passenger
    {
        public Passenger()
        {
            Booking = new HashSet<Booking>();
            Supervisor = new HashSet<Supervisor>();
        }

        public int PassengerId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string MobileNo { get; set; }
        public string Address { get; set; }
        public string DisabilityType { get; set; }

        public virtual ICollection<Booking> Booking { get; set; }
        public virtual ICollection<Supervisor> Supervisor { get; set; }
    }
}
