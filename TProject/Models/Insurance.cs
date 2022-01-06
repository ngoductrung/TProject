﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace TProject.Models
{
    public partial class Insurance
    {
        public string Np { get; set; }
        public DateTime Ifrom { get; set; }
        public DateTime Ito { get; set; }

        public virtual BusInfo NpNavigation { get; set; }
    }
}
