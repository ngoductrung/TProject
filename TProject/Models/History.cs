using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace TProject.Models
{
    public partial class History
    {
        public string Np { get; set; }
        public string Management { get; set; }
        public DateTime Time { get; set; }
        public double MaxSpeed { get; set; }
        public double MinSpeed { get; set; }
        public double AverageSpeed { get; set; }
        public double TripLength { get; set; }

        public virtual Management ManagementNavigation { get; set; }
        public virtual BusInfo NpNavigation { get; set; }
    }
}
