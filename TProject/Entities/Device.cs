using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace TProject.Entities
{
    public partial class Device
    {
        public Device()
        {
            BusInfo = new HashSet<BusInfo>();
        }

        public string DeviceId { get; set; }
        public string Sim { get; set; }
        public string Skind { get; set; }
        public string NetworkOp { get; set; }
        public DateTime Active { get; set; }
        public string Management { get; set; }
        public string Imei { get; set; }
        public bool Status { get; set; }
        public string Latitude { get; set; }
        public string Longtitude { get; set; }

        public virtual Management ManagementNavigation { get; set; }
        public virtual ICollection<BusInfo> BusInfo { get; set; }
    }
}
