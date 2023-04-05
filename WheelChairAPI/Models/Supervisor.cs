using System;
using System.Collections.Generic;

namespace WheelChairAPI.Models
{
    public partial class Supervisor
    {
        public int? PassengerId { get; set; }
        public int? Pnrno { get; set; }
        public int? Wid { get; set; }
        public int? StaffId { get; set; }
        public int SupervisorId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string MobileNo { get; set; }

        public virtual Passenger Passenger { get; set; }
        public virtual Booking PnrnoNavigation { get; set; }
        public virtual AirportStaff Staff { get; set; }
        public virtual WheelChair W { get; set; }
    }
}
