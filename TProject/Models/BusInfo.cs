using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace TProject.Models
{
    public partial class BusInfo
    {
        public string Np { get; set; }
        public string Automaker { get; set; }
        public string Management { get; set; }
        public string DriverId { get; set; }
        public string DeviceId { get; set; }
        public string Rfid { get; set; }

        public virtual Device Driver { get; set; }
        public virtual Management ManagementNavigation { get; set; }
        public virtual Rfid Rf { get; set; }
        public virtual Driver DriverNavigation { get; set; }
        public virtual Fixing Fixing { get; set; }
        public virtual History History { get; set; }
        public virtual Insurance Insurance { get; set; }
        public virtual Maintain Maintain { get; set; }
        public virtual Oil Oil { get; set; }
        public virtual Register Register { get; set; }
    }
}
