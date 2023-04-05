using System;
using System.Collections.Generic;

namespace WheelChairAPI.Models
{
    public partial class WheelChair
    {
        public WheelChair()
        {
            Supervisor = new HashSet<Supervisor>();
        }

        public int Wid { get; set; }
        public int? GateNo { get; set; }
        public string Status { get; set; }

        public virtual ICollection<Supervisor> Supervisor { get; set; }
    }
}
