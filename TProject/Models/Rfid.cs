using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace TProject.Models
{
    public partial class Rfid
    {
        public Rfid()
        {
            BusInfo = new HashSet<BusInfo>();
        }

        public string Rfid1 { get; set; }
        public string Info { get; set; }
        public DateTime Active { get; set; }
        public string Management { get; set; }

        public virtual Management ManagementNavigation { get; set; }
        public virtual ICollection<BusInfo> BusInfo { get; set; }
    }
}
