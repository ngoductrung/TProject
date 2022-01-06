using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace TProject.Models
{
    public partial class Maintain
    {
        public string Np { get; set; }
        public DateTime LastTime { get; set; }
        public string Info { get; set; }

        public virtual BusInfo NpNavigation { get; set; }
    }
}
