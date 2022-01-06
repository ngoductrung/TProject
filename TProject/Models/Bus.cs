using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace TProject.Models
{
    public partial class Bus
    {
        public string Id { get; set; }
        public string Typ { get; set; }
        public string Belong { get; set; }
        public DateTime LastMt { get; set; }
        public DateTime Isurance { get; set; }
        public DateTime Register { get; set; }
        public int KmperDay { get; set; }
        public double TimeperDay { get; set; }
        public int Alert { get; set; }
        public int Trip { get; set; }
    }
}
