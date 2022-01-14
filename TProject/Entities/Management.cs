using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace TProject.Entities
{
    public partial class Management
    {
        public Management()
        {
            Alert = new HashSet<Alert>();
            Atmtechnicians = new HashSet<Atmtechnicians>();
            BusInfo = new HashSet<BusInfo>();
            Device = new HashSet<Device>();
            Driver = new HashSet<Driver>();
            History = new HashSet<History>();
            Owner = new HashSet<Owner>();
            Rfid = new HashSet<Rfid>();
            Stop = new HashSet<Stop>();
            Users = new HashSet<Users>();
        }

        public string Name { get; set; }
        public string Info { get; set; }
        public string City { get; set; }
        public bool Active { get; set; }

        public virtual ICollection<Alert> Alert { get; set; }
        public virtual ICollection<Atmtechnicians> Atmtechnicians { get; set; }
        public virtual ICollection<BusInfo> BusInfo { get; set; }
        public virtual ICollection<Device> Device { get; set; }
        public virtual ICollection<Driver> Driver { get; set; }
        public virtual ICollection<History> History { get; set; }
        public virtual ICollection<Owner> Owner { get; set; }
        public virtual ICollection<Rfid> Rfid { get; set; }
        public virtual ICollection<Stop> Stop { get; set; }
        public virtual ICollection<Users> Users { get; set; }
    }
}
