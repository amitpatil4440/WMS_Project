using System;
using System.Collections.Generic;

namespace WheelChairAPI.Models
{
    public partial class AirportStaff
    {
        public AirportStaff()
        {
            Supervisor = new HashSet<Supervisor>();
        }

        public int StaffId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string MobileNo { get; set; }

        public virtual ICollection<Supervisor> Supervisor { get; set; }
    }
}
