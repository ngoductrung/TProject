using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace TProject.Entities
{
    public partial class Stop
    {
        public string Sid { get; set; }
        public string Sname { get; set; }
        public string Kind { get; set; }
        public string Management { get; set; }
        public string Addr { get; set; }

        public virtual Management ManagementNavigation { get; set; }
    }
}
